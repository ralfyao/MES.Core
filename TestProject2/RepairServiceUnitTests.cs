using MES.Core;
using MES.Core.Model;
using MES.Core.Repository.Impl;

namespace TestProject2
{
    /// <summary>
    /// 維修服務單 — Repository 層單元測試
    /// 直接操作資料庫，驗證各 CRUD 方法正確性
    /// </summary>
    public class RepairServiceUnitTests
    {
        private RepairFormRepository _repo;
        private string _testFormNo;

        [SetUp]
        public void Setup()
        {
            _repo = new RepairFormRepository();
            _testFormNo = $"RS_TEST_{DateTime.Now.ToString("yyyyMMddHHmmss")}";
        }

        [TearDown]
        public void TearDown()
        {
            // 清除測試資料，避免殘留
            try
            {
                var form = new 維修服務單 { 單號 = _testFormNo };
                _repo.Delete(form);
            }
            catch { }
        }

        // ── GetList ──────────────────────────────────────────────────────────

        [Test]
        public void GetList_應回傳維修服務單清單()
        {
            var list = _repo.GetList(null, "TOP 100", "");
            Assert.IsNotNull(list);
        }

        [Test]
        public void GetListBy_以客戶簡稱篩選_應回傳對應資料()
        {
            var condition = new 維修服務單 { 客戶簡稱 = "NONEXIST_CUSTOMER" };
            var list = _repo.GetListBy(condition, "客戶簡稱");
            Assert.IsNotNull(list);
            Assert.IsEmpty(list);
        }

        // ── Insert ───────────────────────────────────────────────────────────

        [Test]
        public void Insert_新增維修服務單_應成功寫入()
        {
            var form = BuildTestForm();
            int execCnt = _repo.Insert(form);
            Assert.Greater(execCnt, 0, "Insert 應回傳影響列數 > 0");
        }

        [Test]
        public void Insert_新增後GetUnique_應能取回相同單號()
        {
            var form = BuildTestForm();
            _repo.Insert(form);

            var key = new 維修服務單 { 單號 = _testFormNo };
            var result = _repo.GetUnique(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(_testFormNo, result.單號);
            Assert.AreEqual("TEST_CUST", result.客戶簡稱);
        }

        // ── Update ───────────────────────────────────────────────────────────

        [Test]
        public void Update_修改維修服務單_應成功更新()
        {
            var form = BuildTestForm();
            _repo.Insert(form);

            form.故障情形 = "更新後的故障描述";
            form.維修地點 = "台南廠";
            int execCnt = _repo.Update(form);

            Assert.Greater(execCnt, 0, "Update 應回傳影響列數 > 0");

            var key = new 維修服務單 { 單號 = _testFormNo };
            var result = _repo.GetUnique(key);
            Assert.AreEqual("更新後的故障描述", result.故障情形);
            Assert.AreEqual("台南廠", result.維修地點);
        }

        [Test]
        public void Update_日期含斜線_應自動轉換格式()
        {
            var form = BuildTestForm();
            _repo.Insert(form);

            form.申請日期 = "2025/06/25";
            form.希望服務日期 = "2025/07/01";
            Assert.DoesNotThrow(() => _repo.Update(form));

            var key = new 維修服務單 { 單號 = _testFormNo };
            var result = _repo.GetUnique(key);
            Assert.IsFalse(result.申請日期?.Contains("/"), "日期不應含斜線");
        }

        // ── Delete ───────────────────────────────────────────────────────────

        [Test]
        public void Delete_刪除維修服務單_應從資料庫移除()
        {
            var form = BuildTestForm();
            _repo.Insert(form);

            var toDelete = new 維修服務單 { 單號 = _testFormNo };
            int execCnt = _repo.Delete(toDelete);
            Assert.Greater(execCnt, 0, "Delete 應回傳影響列數 > 0");

            var key = new 維修服務單 { 單號 = _testFormNo };
            var result = _repo.GetUnique(key);
            Assert.IsNull(result);
        }

        // ── Constructor from 客戶訴願處理單 ─────────────────────────────────

        [Test]
        public void 維修服務單Constructor_從客訴單建立_屬性應正確對應()
        {
            var carForm = new 客戶訴願處理單
            {
                客戶簡稱 = "CUST_A",
                客戶名稱 = "客戶A股份有限公司",
                專案序號 = "PRJ-001",
                機台型號 = "MODEL-X",
                機台名稱 = "測試機台",
                訴願聯絡窗口 = "王小明",
                回覆日期 = "2025-07-01",
                客戶反應 = "機台異常震動",
                原因類別1 = "機械",
                原因鑑定1 = "軸承磨損",
                簡要描述1 = "Y軸軸承異常"
            };

            var repairForm = new 維修服務單(carForm);

            Assert.AreEqual("CUST_A", repairForm.客戶簡稱);
            Assert.AreEqual("客戶A股份有限公司", repairForm.客戶名稱);
            Assert.AreEqual("PRJ-001", repairForm.專案序號);
            Assert.AreEqual("王小明", repairForm.客戶聯絡窗口);
            Assert.AreEqual("2025-07-01", repairForm.希望服務日期);
            Assert.AreEqual("機台異常震動", repairForm.客戶反應);
            Assert.AreEqual("機械", repairForm.原因類別1);
            Assert.AreEqual("軸承磨損", repairForm.原因鑑定1);
            Assert.IsNotNull(repairForm.申請日期);
        }

        // ── Helpers ──────────────────────────────────────────────────────────

        private 維修服務單 BuildTestForm()
        {
            return new 維修服務單
            {
                單號 = _testFormNo,
                申請日期 = DateTime.Now.ToString("yyyy-MM-dd"),
                客戶簡稱 = "TEST_CUST",
                客戶名稱 = "測試客戶有限公司",
                專案序號 = "PRJ-TEST",
                機台型號 = "MODEL-TEST",
                機台類型 = "標準型",
                機台名稱 = "單元測試機台",
                客戶聯絡窗口 = "測試窗口",
                維修地點 = "客戶端",
                希望服務日期 = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd"),
                故障情形 = "單元測試故障描述",
                處置建議 = "單元測試處置建議",
                服務型態 = "現場維修",
                建檔 = "TEST_USER",
                建檔日 = DateTime.Now.ToString("yyyy-MM-dd"),
                原因類別1 = "電氣",
                簡要描述1 = "控制器異常",
                原因鑑定1 = "驅動器故障",
                轉零件申請 = false
            };
        }
    }
}
