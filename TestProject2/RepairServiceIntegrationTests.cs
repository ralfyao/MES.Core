using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.MiddleWare.Modules;

namespace TestProject2
{
    /// <summary>
    /// 維修服務單 — Middleware 層整合測試
    /// 驗證業務邏輯、單號產生、轉換流程等跨層行為
    /// </summary>
    public class RepairServiceIntegrationTests
    {
        private CustomerMiddle _middle;
        private string _testFormNo;
        private RepairFormRepository _repo;

        [SetUp]
        public void Setup()
        {
            _middle = new CustomerMiddle();
            _repo = new RepairFormRepository();
            _testFormNo = $"RS_IT_{DateTime.Now.ToString("yyyyMMddHHmmss")}";
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                var form = new 維修服務單 { 單號 = _testFormNo };
                _repo.Delete(form);
            }
            catch { }
        }

        // ── 單號產生 ─────────────────────────────────────────────────────────

        [Test]
        public void getRepairFormNo_應產生RS開頭且含日期的單號()
        {
            string formNo = _middle.getRepairFormNo();
            Assert.IsNotNull(formNo);
            Assert.IsNotEmpty(formNo);
            StringAssert.StartsWith("RS", formNo);
            StringAssert.Contains(DateTime.Now.ToString("yyyyMMdd"), formNo);
        }

        [Test]
        public void getRepairFormNo_連續呼叫兩次_單號應遞增()
        {
            string no1 = _middle.getRepairFormNo();
            _middle.saveRepairTest(BuildTestForm(no1));

            string no2 = _middle.getRepairFormNo();
            Assert.AreNotEqual(no1, no2, "連續兩次取號應不同");

            // 清理 no1
            _middle.deleteRepairTest(new 維修服務單 { 單號 = no1 });
        }

        [Test]
        public void get零件申請FormNo_應產生SP開頭且含日期的單號()
        {
            string formNo = _middle.get零件申請FormNo();
            Assert.IsNotNull(formNo);
            Assert.IsNotEmpty(formNo);
            StringAssert.StartsWith("SP", formNo);
            StringAssert.Contains(DateTime.Now.ToString("yyyyMMdd"), formNo);
        }

        // ── 查詢 ─────────────────────────────────────────────────────────────

        [Test]
        public void getRepairTestList_應回傳清單不為Null()
        {
            var list = _middle.getRepairTestList();
            Assert.IsNotNull(list);
        }

        [Test]
        public void queryRepairTestListByCondition_空條件_應回傳資料()
        {
            var list = _middle.queryRepairTestListByCondition(null);
            Assert.IsNotNull(list);
        }

        [Test]
        public void queryRepairTestListByCondition_不存在客戶_應回傳空清單()
        {
            var list = _middle.queryRepairTestListByCondition("NONEXIST_XYZ_9999");
            Assert.IsNotNull(list);
            Assert.IsEmpty(list);
        }

        [Test]
        public void getRepairtorList_應回傳有效維修人員清單()
        {
            var list = _middle.getRepairtorList();
            Assert.IsNotNull(list);
        }

        // ── 新增 ─────────────────────────────────────────────────────────────

        [Test]
        public void saveRepairTest_新增維修服務單_應成功()
        {
            var form = BuildTestForm(_testFormNo);
            int execCnt = _middle.saveRepairTest(form);
            Assert.Greater(execCnt, 0);
        }

        [Test]
        public void saveRepairTest_新增後可查詢到_應出現在清單中()
        {
            var form = BuildTestForm(_testFormNo);
            _middle.saveRepairTest(form);

            var list = _middle.queryRepairTestListByCondition("IT_CUST");
            Assert.IsTrue(list.Any(x => x.單號 == _testFormNo),
                "新增的維修單應出現在查詢結果中");
        }

        // ── 更新 ─────────────────────────────────────────────────────────────

        [Test]
        public void updateRepairTest_更新維修服務單_應成功()
        {
            var form = BuildTestForm(_testFormNo);
            _middle.saveRepairTest(form);

            form.故障情形 = "整合測試更新故障描述";
            form.實際服務日期 = DateTime.Now.ToString("yyyy-MM-dd");
            int execCnt = _middle.updateRepairTest(form);

            Assert.Greater(execCnt, 0);
        }

        [Test]
        public void updateRepairTest_更新後查詢_應反映新值()
        {
            var form = BuildTestForm(_testFormNo);
            _middle.saveRepairTest(form);

            form.維修服務時數 = 8;
            form.維修結案日期 = DateTime.Now.ToString("yyyy-MM-dd");
            _middle.updateRepairTest(form);

            var key = new 維修服務單 { 單號 = _testFormNo };
            var result = _repo.GetUnique(key);
            Assert.AreEqual(8, result.維修服務時數);
        }

        // ── 刪除 ─────────────────────────────────────────────────────────────

        [Test]
        public void deleteRepairTest_刪除維修服務單_應成功()
        {
            var form = BuildTestForm(_testFormNo);
            _middle.saveRepairTest(form);

            int execCnt = _middle.deleteRepairTest(new 維修服務單 { 單號 = _testFormNo });
            Assert.Greater(execCnt, 0);
        }

        [Test]
        public void deleteRepairTest_刪除後查詢_應不存在()
        {
            var form = BuildTestForm(_testFormNo);
            _middle.saveRepairTest(form);
            _middle.deleteRepairTest(new 維修服務單 { 單號 = _testFormNo });

            var key = new 維修服務單 { 單號 = _testFormNo };
            var result = _repo.GetUnique(key);
            Assert.IsNull(result);
        }

        // ── 轉換流程：從客訴單轉維修服務單 ─────────────────────────────────

        [Test]
        public void transferToRepair_從客訴單建立_應產生維修服務單號()
        {
            var carForm = BuildTestCARForm();
            var resultForm = _middle.transferToRepair(carForm);

            Assert.IsNotNull(resultForm.維修服務單號);
            Assert.IsNotEmpty(resultForm.維修服務單號);
            Assert.AreEqual(1, resultForm.轉維修);

            // 清理
            try
            {
                _middle.deleteRepairTest(new 維修服務單 { 單號 = resultForm.維修服務單號 });
            }
            catch { }
        }

        [Test]
        public void transferToRepair_建立後可在維修清單中查詢到()
        {
            var carForm = BuildTestCARForm();
            var resultForm = _middle.transferToRepair(carForm);

            var list = _middle.getRepairTestList();
            Assert.IsTrue(list.Any(x => x.單號 == resultForm.維修服務單號),
                "從客訴單轉換的維修服務單應出現在清單中");

            // 清理
            try
            {
                _middle.deleteRepairTest(new 維修服務單 { 單號 = resultForm.維修服務單號 });
            }
            catch { }
        }

        // ── 轉換流程：維修服務單轉零件申請單 ───────────────────────────────

        [Test]
        public void transferRepairTo零件申請單_應成功新增零件申請單()
        {
            var form = BuildTestForm(_testFormNo);
            _middle.saveRepairTest(form);

            int execCnt = _middle.transferRepairTo零件申請單(form);
            Assert.Greater(execCnt, 0, "轉零件申請單應回傳影響列數 > 0");

            // 驗證維修服務單的零件工令編號有被填入
            var key = new 維修服務單 { 單號 = _testFormNo };
            var updated = _repo.GetUnique(key);
            Assert.IsNotNull(updated.零件工令編號);
            Assert.IsNotEmpty(updated.零件工令編號);
            Assert.IsTrue(updated.轉零件申請 == true, "轉零件申請 flag 應為 true");

            // 清理零件申請單
            try
            {
                WorkOrderMiscRepository wmRepo = new WorkOrderMiscRepository();
                wmRepo.Delete(new 零件申請單 { 單號 = updated.零件工令編號 });
            }
            catch { }
        }

        [Test]
        public void transferRepairTo零件申請單_產生的零件申請單號_應SP開頭()
        {
            var form = BuildTestForm(_testFormNo);
            _middle.saveRepairTest(form);
            _middle.transferRepairTo零件申請單(form);

            var key = new 維修服務單 { 單號 = _testFormNo };
            var updated = _repo.GetUnique(key);

            StringAssert.StartsWith("SP", updated.零件工令編號);

            // 清理零件申請單
            try
            {
                WorkOrderMiscRepository wmRepo = new WorkOrderMiscRepository();
                wmRepo.Delete(new 零件申請單 { 單號 = updated.零件工令編號 });
            }
            catch { }
        }

        // ── 原因類別清單 ─────────────────────────────────────────────────────

        [Test]
        public void getCARRepairReasonList_應回傳類別清單()
        {
            var list = _middle.getCARRepairReasonList();
            Assert.IsNotNull(list);
        }

        // ── Helpers ──────────────────────────────────────────────────────────

        private 維修服務單 BuildTestForm(string formNo)
        {
            return new 維修服務單
            {
                單號 = formNo,
                申請日期 = DateTime.Now.ToString("yyyy-MM-dd"),
                客戶簡稱 = "IT_CUST",
                客戶名稱 = "整合測試客戶有限公司",
                專案序號 = "PRJ-IT",
                機台型號 = "MODEL-IT",
                機台類型 = "標準型",
                機台名稱 = "整合測試機台",
                客戶聯絡窗口 = "整合測試窗口",
                維修地點 = "客戶端",
                希望服務日期 = DateTime.Now.AddDays(5).ToString("yyyy-MM-dd"),
                故障情形 = "整合測試故障描述",
                處置建議 = "整合測試處置建議",
                服務型態 = "現場維修",
                建檔 = "IT_USER",
                建檔日 = DateTime.Now.ToString("yyyy-MM-dd"),
                原因類別1 = "電氣",
                簡要描述1 = "控制器異常",
                原因鑑定1 = "驅動器故障",
                轉零件申請 = false
            };
        }

        private 客戶訴願處理單 BuildTestCARForm()
        {
            return new 客戶訴願處理單
            {
                單號 = $"CAR_IT_{DateTime.Now.ToString("yyyyMMddHHmmss")}",
                客戶簡稱 = "IT_CUST",
                客戶名稱 = "整合測試客戶有限公司",
                專案序號 = "PRJ-IT",
                機台型號 = "MODEL-IT",
                機台名稱 = "整合測試機台",
                訴願聯絡窗口 = "測試窗口",
                回覆日期 = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"),
                客戶反應 = "整合測試客戶反應",
                原因類別1 = "機械",
                原因鑑定1 = "軸承磨損",
                簡要描述1 = "Y軸軸承異常",
                轉維修 = 0
            };
        }
    }
}
