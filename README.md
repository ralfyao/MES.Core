# DigiERP 專案功能總覽

> 最後更新：2026-08-10　　Branch：master　　Commit：83fcb49

---

## 系統架構

```
DigiERP (WinForms UI)
    └─ MES.WebAPI.Controllers  (直接 new 物件呼叫，非 HTTP)
        └─ MES.MiddleWare       (業務邏輯層)
            └─ MES.Core         (Dapper + Raw SQL, Repository Pattern)
```

---

## 一、DigiERP 前端模組 (UserControl)

### 客戶管理 (Customer)
| 模組 | 功能說明 |
|------|---------|
| CustomerControl | 客戶資料主列表：查詢、新增、進入維護頁 |
| CustomerMaintainControl | 客戶資料維護：基本資料、聯絡人、國別、產業別 |
| **SalesOrder** | 客戶訂單管理：訂單查詢、新增、修改、明細維護 |
| **Quotation** | 報價單管理：報價查詢、新增、修改、品項明細 |
| **RFQ** | 客戶詢問函：詢問函建立、聯絡紀錄追蹤 |
| **ShippingOrder** | 出貨單管理：出貨查詢、新增、出貨明細 |
| **EQPCSustService** | 機台客服管理：客服記錄建立與追蹤 |
| **CAR** | 客訴及客戶訴願處理單：客訴記錄、原因類別管理 |
| **Repair** | **維修服務單**：維修申請、查修結果、零件申請轉單、生效核准 |
| **Receivables** | 應收帳款管理：帳款查詢、沖帳作業 |

### 供應商管理 (Supplier) — 已完成
| 模組 | 功能說明 |
|------|---------|
| SupplierControl | 廠商主列表：查詢（編號/名稱）、隱藏停用篩選、新增、雙擊進入維護頁 |
| SupplierMaintainControl | 廠商資料維護：基本資料、聯絡人（放大鏡開 FrmSelectContact 選取）、生效/取消生效、停用/取消停用、刪除；下方內嵌「供料詢價明細」表格 |
| **供料詢價 (Supplier Quotation)** | 廠商維護頁按「供料詢價」→ 開 FrmAddSupplierQuotation 新增視窗 → 選品項（FrmSelectMaterial 彈窗查 A材料）自動帶入採購單位 → 填最低/最大採購量、單價、幣別、詢價人員、報價有效日期、廠商品號 → SAVE 寫入後關閉並刷新明細表格 |
| FrmSelectContact | 廠商聯絡名冊選取彈窗：雙擊帶回聯絡人資料，並可整批儲存聯絡名冊 |
| FrmSelectMaterial | 品項（A材料）選取彈窗：可依產品編號/代號/品名規格搜尋，雙擊或選取鈕帶回品項編號、採購單位 |
| FrmAddSupplierQuotation | 新增供料詢價彈窗（放在 `Forms/Supplier`）：廠商編號唯讀帶入、詢價/報價有效日期、幣別與詢價人員下拉（詢價人員來源為成本單位人員配置 職務="採購" AND 編修=1） |

### 生產排程 (Production/Scheduling) — 新增
| 模組 | 功能說明 |
|------|---------|
| ProjectScheduleQueryControl | 專案排程查詢頁：7 個日期（查詢起日＋第一~六週，自動遞增 7 天）+ 6 個類別按鈕（設計/採購/機加工/後製程/組測/程控），分別開啟對應排程頁籤 |
| DesignScheduleControl | 週排程-設計：查詢起日+6週的 7 欄日期分桶樞紐表，含每週派案工時/應計工時(固定40)/負荷率統計列 |
| ProcurementSchedulingControl | 週排程-採購：基準日以前+4週的 5 欄分桶（依預計到貨日），未入排程欄位固定排在最後一欄，footer 以筆數(COUNT)統計、負荷率固定40 |
| MachiningSchedulingControl | 週排程-機加工：基準日以前+4週分桶（依預交日期1），末欄標示為「第五週(含)以後」（非單純未排入），負荷率固定40 |
| PostProcessSchedulingControl | 週排程-後製程：無日期分桶，改以特殊塑型/精密加工/防變形/表面處理 4 個製程階段群組（各含預計排程日/委外派工日 2 欄），群組標題動態對齊欄寬，負荷率固定60 |
| AssemTestSchedulingControl | 週排程-組裝測試：第一~四週各含進料排程/加工排程 2 欄，群組標題顯示「第N週：日期」，footer 每週筆數為進料或加工任一有值即算一筆，負荷率固定60 |

### 設計 / 圖面 / 用料 (Production/Design) — 新增
| 模組 | 功能說明 |
|------|---------|
| DesignDispatchControl | 設計派案總覽：列出全部設計派案，可編修設計人員/圖類/檔名/預計完工日等派工欄位並批次儲存；點『設計人員』欄位開啟 `FrmWorkLogEntry` 直接登錄工作日誌 |
| DesignAuditControl / DesignAuditMaintainControl | 設計審圖總覽/審查清單維護：雙擊清單編號進入維護頁；新單首次儲存自動產生清單編號（`DA`+yyyyMMdd+序號2位）；「生效/取消生效」僅具核准權限者可用，寫入/清空審圖通過、發行人員、圖檔發行日 |
| DesignIssueControl | 專案用料總覽：列出「圖面發行轉BOM」後尚未指定用途的模組明細，依專案序號/零件號碼/品名前端模糊篩選，雙擊進入 BOM 維護 |
| ModuleMaterialMaintainControl | 專案模組用料清單維護（BOM）：依 BOM 編號顯示表頭與 BOM 明細，可編修組裝資訊並新增/儲存 BOM 項目；表身整批刪除重建 |
| AssemblyDispatchReceiveControl | 組裝派案及領料作業：列出全部專案模組用料清單，可指定組裝人員/日期/結案回報/用途；『結案回報』選『設計變更』即刻寫回完工日期並自動開啟(或切回)「異常矯正措施報告」頁籤；雙擊『專案序號』開啟「專案機台組測紀錄表」；『製圖檔名』開啟 FrmMaterialRequisitionList（零配件領料） |
| ProjectMachineTestRecordControl | 專案機台組測紀錄表：表頭取自工令單 LEFT JOIN 產品規格單，下方兩明細清單呈現組裝派案進度與組測工作紀錄（純唯讀顯示；油壓單元/製程參數表/出機檢查表按鈕尚未開放） |
| AbnormalCorrectionReportOverviewControl / AbnormalCorrectionReportControl | 異常矯正措施報告：由「組裝派案及領料作業」結案回報選『設計變更』時開啟，依來源單據載入(或新建)一筆報告；客戶簡稱/機台型號/機台類型/機台名稱唯讀（依專案序號從工令單查詢帶出）；單號規則 `ER`+西元年4位+流水號3位，僅新單且單號為空時產生 |

### 電控排程 / 試機驗收 (Production/ProgramControl, TestValidationReport) — 新增
| 模組 | 功能說明 |
|------|---------|
| ProgramControlListControl | 電控排程：列表維護畫面，資料來源為 `專案電控排程`；程控人員欄位以 Grid-cell 攔截下拉開啟 `FrmSelectStaff` 選取；點選專案序號（僅檢視模式）開啟 `ProjectMachineProgramControlRecordControl` |
| ProjectMachineProgramControlRecordControl | 專案機台程控紀錄表：由「電控排程」點選專案序號開啟；表頭取自產品規格單 LEFT JOIN 工令單，含 6 項說明書資料夾項目 checkbox（可修改並即時 UPDATE 後台，其餘欄位唯讀）；下方兩個 Grid：專案程控排程、專案程控履歷 |
| MiscControlOrderControl | 零件管制報告書：表頭資料來源為採購計畫；下方「零件生產工序」（依製程對應不同工作站選項）、「零件檢驗履歷」（尺寸精度/幾何精度/材質標準等 7 項檢驗結果下拉）兩個明細清單皆可編輯儲存；「生效/取消生效」寫入/清空核准與核准日，生效後自動開啟「異常矯正措施報告」頁籤 |
| MiscControlReportControl | 零件管制報告總覽：列出已建立零件管制單號的採購計畫，可依專案序號/零件號碼/品名篩選 |
| TestValidationReportControl | 試機驗收單總覽：以 `賣方廠驗收單` 為主表，聯集工令單/產品規格單資料列表；按「Add」開啟空白新增頁籤，點選專案序號開啟(或切換至)對應維護頁籤 |
| TestValidationMaintainControl | 賣方廠驗收單維護：大型多區塊表單（含 10 列固定規格 Grid、`專案焊接測試數據`／`專案改正措施內容` 兩個可編輯子表格）；「覆核/取消覆核」寫入/清空核准與核准日並同步鎖控「修改」與「列印」；列印前需先透過 `FrmWeldTestDataEntry` 填寫焊接測試數據 |

### 庫存 / 採購 (Inventory) — 新增
| 模組 | 功能說明 |
|------|---------|
| ToButListControl | 請購底稿：`B請購需求` 扁平化可編輯表格，一開始整表唯讀，按「修改」才能新增列/編輯，「儲存」只送出實際異動過的列（dirty-row 追蹤），項目編號/廠商/員工代碼皆有 Trim + 強制塞入下拉清單機制避免資料對不上而拋例外 |
| ProjectProcurementControl | 採購計畫：`採購計畫` 表整批瀏覽與追蹤欄位（零件分類/採購人員/實際採購日/預計到貨日/倉管人員/入庫移轉日/驗收結果）維護，僅對這幾個欄位做 SQL UPDATE（不覆寫開工/完工日期等其他排程欄位，避免影響週排程系列畫面），含「複式篩選器」彈窗（專案序號/模組編碼/零件號碼）與清除篩選 |
| FrmProjectProcurementFilter | 複式篩選彈窗：三個下拉條件（依目前清單資料取不重複值）+ 確定/離開 |
| StockInCertControl / StockInCertMaintainControl | 進項憑證登載總覽/維護：`F付款` 主檔（收付別=付），可分「現金/銀轉/票據/電匯」與「發票/收據/其他」；新增付款可透過「應收/驗收憑證匯入」（FrmStockInCertImport／依 5% 稅率反推未稅金額）、「預付款項匯入」（FrmPrepaymentSelect）、「費用憑證匯入」（FrmExpenseCertImport）批次帶入明細；「覆核」寫入核准人員/核准日 |
| PaymentOffsetOverviewControl / PaymentOffsetMaintainControl | 付款沖帳總覽：依日期分「60天內／超過60天」兩種檢視切換列表 |

### 銀行 / 資金調節 (Objective/Bank) — 新增
| 模組 | 功能說明 |
|------|---------|
| BankControl / BankMaintainControl | 銀行帳戶總覽/維護：`F銀行設定` CRUD；維護頁含「明細」按鈕開啟 `FrmBankLedgerDetail` |
| FrmBankLedgerDetail | 銀行明細總覽：列出指定銀行帳戶明細，可篩選本月/上月/逾60天/指定月份，統計支出/存入合計 |
| FrmBankDeposit | 匯入款（存入）維護：依連結單號查詢/新增銀行明細存入紀錄，鎖定顯示需按「修改」才可編輯，寫入 `F銀行明細` |
| BankMonthSummaryBalance | 銀行月結餘額總覽：依月底日期列出各銀行帳戶存入/支出/餘額，可執行「月結確定」寫入月結紀錄 |
| CurrencyAdjustControl / CurrencyAdjustMaintainControl | 資金調節總覽/維護：`F資金調節` CRUD，單號自動產生，「覆核/取消覆核」寫入/清空核准狀態 |

### 會計 / 總務 (Accounts) — 新增
| 模組 | 功能說明 |
|------|---------|
| GeneralExpensesControl | 總務支出單總覽：`F總務支出單` 列表，未結案/已結案篩選、點選單號於頁籤中開啟維護畫面、新增按鈕 |
| GeneralExpensesMaintainControl | 總務支出單維護：廠商編號可用下拉或放大鏡開 `FrmSelectSupplier` 選取、採購人員/幣別匯率/付款條件/採購類別/營業稅率下拉、明細表輸入原幣未稅自動依匯率換算台幣未稅與稅額並加總為金額；新增模式下修改/覆核/取消覆核/列印按鈕隱藏，點開既有單據預設鎖定需按「修改」才能編輯，儲存成功後自動關閉頁籤並刷新列表 |
| VoucherQueryControl | 會計傳票查詢：複式條件（日期區間/會科代碼/狀態）或傳票編號模糊查詢，點選主檔列帶出明細並統計借貸合計，點明細列可直接跳出 `FrmVoucher` 顯示/編輯 |
| BillControl / FrmBill | 票據管理總覽/維護：`F票據異動` CRUD；對象名稱依「收付別」動態解析廠商或客戶名稱；銀行帳號依所選銀存編碼自動帶出 |

### 目標管理 (Objective)
| 模組 | 功能說明 |
|------|---------|
| ARWriteOff / ARWriteOffMaintainControl | 收款單（沖款收）總覽/維護：依客戶編號列出收款單，彙總原幣/台幣/折讓/匯差；單號自動產生（`BR`+yyyyMM+3位序號）；「覆核/取消覆核」寫入/清空核准狀態，覆核後擋「應收款導入」；「應收款導入」開啟 `FrmARImport` 挑選 `F帳款管理` 未結案帳款批次帶入表身 |
| ExRateRegisterControl | 匯率設定：`F匯率` 依幣別瀏覽（◄/►切換），日期欄為 DateTimePicker，編輯完離開該列即自動存檔（有異動才新增或更新，未異動的列不會觸發） |
| SalesTrackingControl | 客戶活動力分析（業績追蹤）：多層 CTE 統計客戶連絡/詢問/報價/訂單次數與成交率，起日/迄日查詢區間 + REVIEW/RESET，點選客戶欄位於頁籤中開啟該客戶的客戶維護畫面 |

### 共用元件 (Common)
| 元件 | 功能說明 |
|------|---------|
| BankCodeSelect | 銀行代碼下拉選取 |
| CountrySelect | 國別下拉選取 |
| IndustryCodeSelect | 產業代碼下拉選取 |
| PriceCondControl | 交易條件設定 |
| RFQStatusSelect | 詢問函狀態篩選 |
| SalesSelect | 業務人員選取 |
| FrmSelectStaff | 人員選取共用彈窗：顯示姓名+員工編號清單，雙擊或按確定回傳所選人員（`成本單位人員配置`）給呼叫端；亦作為 DataGridView 儲存格內攔截下拉、改開此彈窗的共用元件 |

---

## 二、WebAPI Controllers (Business API 層)

### CustomerController
- **客戶資料**：查詢/新增/修改/刪除、客戶聯絡明細、客戶國別、產業代碼、`GetCustomerByName`（依客戶名稱查詢，供業績追蹤點選客戶欄位開啟客戶維護使用）
- **詢問函 (RFQ)**：查詢、建立、鎖定/解鎖、聯絡紀錄
- **報價單**：查詢、新增、修改、品項明細維護
- **訂單**：查詢、新增、修改、鎖定/解鎖、訂單明細
- **出貨單**：查詢、新增、修改、出貨明細
- **機台客服**：查詢、新增、修改、明細維護
- **客訴 (CAR)**：客訴處理單 CRUD、原因類別管理
- **維修服務單**：查詢、新增、修改、刪除、流水號取得、生效/取消生效、轉零件申請單
- **維修人員**：`Get組測維修人員List` — 從成本單位人員配置 JOIN H員工清冊取得組測人員
- **銀行主檔**：`GetBankList` — 供 BankControl/BankMaintainControl/StockInCertMaintainControl 共用查詢 `F銀行設定`

### SupplierController
- **廠商主檔**：`GetSupplierList`/`GetAllSupplierList`/`SaveSupplier`/`UpdateSupplier`/`DeleteSupplier`/`GetSupplierNo`
- **生效/停用**：`ValidateSupplier`（生效/取消生效）、`ActivateSupplier`（停用/取消停用）
- **廠商評鑑**：`SaveSupplierEvaluate`、`EvaluateSupplier`
- **聯絡名冊**：`GetContactList`、`ReplaceContactList`（依廠商編號整批刪除重建）
- **供料詢價**：`GetSupplierQuotationList`（含品名規格反查）、`AddSupplierQuotation`（新增單筆）、`UpdateSupplierQuotationList`（整批新增/更新）、`DeleteSupplierQuotation`、`QuotationByItem`（依品項反查所有廠商報價）
- **詢價人員清單**：`GetPurchaseStaffList` — 從成本單位人員配置 JOIN H員工清冊，取職務="採購" 且 編修=1 的人員

### ProcurementController
- 請購需求、採購單 CRUD、進退貨驗收單、採購明細
- `AllPurchaseRequestList`/`SavePurchaseRequest`：請購底稿 (ToButListControl) 沿用之單筆新增或更新（依請購序號是否存在判斷）

### ProjectProgressController — 新增／持續擴充
- 週排程系列：`GetDesignScheduleList`/`GetProcurementScheduleList`/`GetMachiningScheduleList`/`GetPostProcessScheduleList`/`GetAssemTestScheduleList`，皆以 `採購計畫`（部分含 `B請購需求`/`工令單`）多層 CTE 分桶查詢
- 設計/圖面/用料：`GetAllDesignAssignmentList`/`SaveDesignAssignmentBatch`（設計派案）、`GetDesignAuditList`/`SaveDesignAudit`/`ActivateDesignAudit`/`DeactivateDesignAudit`（設計審圖）、`GetModuleMaterialOverviewList`/`GetModuleMaterialByBomNo`/`GetModuleBomDetailList`/`SaveModuleMaterial`（BOM）、`GetModuleMaterialFullList`/`GetModuleMaterialList`/`SaveModuleMaterialHeaderBatch`/`UpdateFinishDateByBomNo`（組裝派案領料）
- 專案機台紀錄：`GetProjectMachineTestRecordHeader`/`GetAssemblyTestWorkLogList`（組測紀錄表）、`GetProjectMachineProgramControlHeader`/`UpdateProductSpecFolderItem`（程控紀錄表）
- 電控排程／程控人員：`GetElecControlProcessList`/`GetProgramControlStaffList`/`GetProgramControlWorkLogList`
- 零件管制／異常矯正：`GetPICStaffList`/`GetInspectionCheckerStaffList`/`GetProductionUnitList`（零件管制報告書下拉來源）、`GetDesignStaffList`/`GetSalesStaffList`/`GetOpenWorkOrderList`/`SaveAbnormalCorrectionReport`（異常矯正措施報告，單號規則見下）
- 試機驗收：`GetTestValidationReportList`/`GetTestValidationReportByProjectNo`/`SaveTestValidationReport`（upsert）/`ValidateTestValidationReport`（覆核/取消覆核）/`GetWeldTestDataList`/`SaveWeldTestData`/`GetCorrectiveActionList`/`SaveCorrectiveActionList`

### GeneralExpensesController — 新增
- 總務支出單 CRUD：`GetGeneralExpensesList`/`GetGeneralExpensesByNo`/`GetGeneralExpensesNo`/`SaveGeneralExpenses`/`UpdateGeneralExpenses`/`DeleteGeneralExpenses`/`ValidateGeneralExpenses`（覆核/取消覆核）/`GetActiveEmployeeList`（狀況正常之員工）

### ProjectProcurementController — 新增
- `GetProjectProcurementList`（`採購計畫` WHERE 入庫移轉日篩選）、`UpdateProjectProcurement`（僅更新採購追蹤欄位，不動排程用欄位）

### ExRateController — 新增
- `GetAllExRateList`/`SaveExRate`（識別=0 為新增，否則更新）

### SalesTrackingController — 新增
- `GetSalesTrackingList`：客戶活動力分析多層 CTE 統計（起日/迄日區間）

### BankLedgerController — 新增
- `GetBankLedgerByLinkNo`（依連結單號查詢銀行明細）、`SaveBankLedger`/`UpdateBankLedger`（`F銀行明細` upsert，供匯入款/月結餘額頁使用）

### CurrencyAdjustController — 新增
- `GetCurrencyAdjustList`（資金調節總覽）、`GetFundAdjustNo`（單號產生）、`GetFundAdjustByNo`/`SaveFundAdjust`/`UpdateFundAdjust`/`ValidateFundAdjust`（覆核/取消覆核）/`DeleteFundAdjust`

### BillController — 新增
- `GetBillList`/`GetBillByNo`/`SaveBill`/`UpdateBill`：`F票據異動` CRUD（依識別碼是否為 0 判斷新增或更新）

### ProductionController
- 產品/規格管理、工令單 CRUD、工作紀錄、製令查詢

### ItemController
- 材料/物料主檔、分類管理、庫存品項查詢

### StockInController — 持續擴充
- 進貨入庫單、倉庫管理、入庫作業
- 進項憑證登載：`GetIncomeCertRegByNo`（依單號查詢 `F付款`）、`GetPaymentOffsetOverviewList`（付款沖帳總覽）；驗收/預付款/費用憑證匯入清單查詢（供 `FrmStockInCertImport`/`FrmPrepaymentSelect`/`FrmExpenseCertImport` 使用）

### ARController — 持續擴充
- 應收帳款查詢、收款單、付款單、沖帳作業、其他收入/支出
- 收款單（沖款收）：`GetWriteOffByNo`/`GetWriteOffNo`/`SaveWriteOff`/`UpdateWriteOff`/`ValidateWriteOff`（覆核/取消覆核）/`DeleteWriteOff`/`GetReceivableImportList`（應收款導入，來源 `F帳款管理` 未結案帳款）

### VoucherController
- `GetVoucherQueryList`/`GetVoucherQueryListByNoLike`/`GetVoucherDetailForQuery`：會計傳票查詢主檔/明細（供 VoucherQueryControl 使用）

### HRController
- 員工清冊查詢、職務工作分類、成本單位人員配置
- `getPositionList`/`SaveUpdateJournal`：工作日誌登錄（`FrmWorkLogEntry`）依任務分類自動帶出積分點數，寫入 `工作紀錄A`

### AccountController
- 使用者帳號管理、角色設定、選單權限指派

### MenuController
- 模組選單結構、角色選單對應

### PrivilegeController / UserPrivilegeController
- 使用者授權設定、功能權限管理

### DashboardController
- 儀表板統計資料

### AuthenticateController
- 登入驗證、Token 管理

---

## 三、Middleware 模組 (業務邏輯層)

| 模組 | 主要職責 |
|------|---------|
| **CustomerMiddle** | 客戶/訂單/報價/出貨/客訴/維修服務單的所有業務邏輯，含流水號產生、鎖定機制、轉單作業 |
| **ARMiddle** | 應收帳款計算、收款沖帳、帳款流水號產生；收款單（沖款收）CRUD、單號產生（`BR`+yyyyMM+序號3位）、覆核/取消覆核、應收款導入清單查詢 |
| **SupplierMiddle** | 廠商主檔 CRUD、生效/停用、評鑑、聯絡名冊、供料詢價 CRUD、詢價人員查詢（Dapper + Raw SQL 直接組 SQL） |
| **ProjectProgressMiddle** — 新增／本階段最大宗擴充 | 週排程系列多層 CTE 分桶查詢；設計派案/設計審圖（含單號 `DA`+yyyyMMdd+序號2位）/專案模組用料清單(BOM)/組裝派案領料；程控紀錄表、電控排程、程控人員/工作日誌查詢；零件管制報告書下拉來源；試機驗收單（賣方廠驗收單）upsert/覆核、焊接測試數據、改正措施內容；異常矯正措施報告（單號 `ER`+西元年4位+流水號3位，僅新單且單號空白時透過 `getNewAbnormalCorrectionNo` 於同一交易內產生） |
| **GeneralExpensesMiddle** — 新增 | 總務支出單 CRUD、單號產生、覆核/取消覆核、狀況正常員工查詢；新增/修改透過 `GeneralExpensesDataRepository`（交易內先刪除單頭+明細再重新寫入） |
| **ProjectProcurementMiddle** — 新增 | 採購計畫清單查詢（含入庫移轉日篩選）、追蹤欄位之局部 SQL UPDATE（刻意不用刪除重建，避免波及週排程共用之其他欄位） |
| **ExRateMiddle** — 新增 | 匯率清單查詢、新增或更新（依識別碼是否為 0 判斷） |
| **SalesTrackingMiddle** — 新增 | 客戶活動力分析多層 CTE 統計（客戶訂單/報價/詢問函/連絡次數、成交率，已修正 COUNT 相除的整數除法截斷問題） |
| **BankLedgerMiddle** — 新增 | 銀行明細（`F銀行明細`）查詢/新增/更新，供銀行維護頁「明細」按鈕、匯入款維護、月結餘額頁共用 |
| **CurrencyAdjustMiddle** — 新增 | 資金調節總覽/單筆查詢、單號產生、新增/修改、覆核/取消覆核、刪除 |
| **BillMiddle** — 新增 | 票據異動（`F票據異動`）CRUD |
| **StockInMiddle** — 持續擴充 | 進貨入庫/驗收原有邏輯；擴充進項憑證登載（`F付款`+`F付款明細`）CRUD、覆核、付款沖帳總覽統計、驗收/預付款/費用憑證匯入清單查詢 |
| **VoucherMiddle** — 新增 | 會計傳票查詢主檔/明細（供傳票查詢頁使用） |

---

## 四、資料模型 (MES.Core Model)

### 客戶 / 業務
| 模型 | 對應資料表 |
|------|-----------|
| C客戶設定 | 客戶基本資料 |
| C客戶聯絡明細 | 客戶聯絡人 |
| C客戶國別 | 客戶所在國別 |
| C客戶詢問函 | RFQ 詢問函 |
| C客戶連絡人清單 | 聯絡人清單 |
| C訂單 / C訂單明細 | 銷售訂單主檔 / 明細 |
| C報價單 / C報價明細 | 報價單主檔 / 明細 |
| C出貨單 / C出貨單明細 | 出貨單主檔 / 明細 |
| C機台客服 / C機台客服明細 | 機台客服記錄 |
| C成交潛力值 | 客戶成交評估 |
| C轉介代理 | 代理商轉介記錄 |

### 客訴 / 維修
| 模型 | 對應資料表 |
|------|-----------|
| 客戶訴願處理單 | CAR 客訴處理單 |
| 客訴及維修原因類別 | 原因類別主檔 |
| 維修服務單 | 維修服務單主檔（含故障情形、查修結果、零件申請） |
| 零件申請單 | 零件申請單主檔 |
| 零件申請明細 | 零件申請明細 |
| 零件申請BRG | 零件申請軸承明細 |

### 人事 / 組織
| 模型 | 對應資料表 |
|------|-----------|
| H員工清冊 | 員工基本資料 |
| H職務工作分類 | 職務分類（工作日誌任務分類/積分點數來源） |
| 成本單位人員配置 | 成本單位人員配置（含職務別） |
| A成本單位 | 成本單位主檔 |
| 工作紀錄A | 工作日誌明細（`FrmWorkLogEntry` 登錄，日誌單號=員工編號+yyyyMMdd） |

### 採購
| 模型 | 對應資料表 |
|------|-----------|
| B廠商設定 / B廠商聯絡名冊 | 廠商主檔 / 聯絡人 |
| B廠商評鑑 | 廠商評鑑記錄 |
| B廠商供料 | 廠商供料詢價明細（品項、採購單位、最低/最大採購量、單價、幣別、詢價人員、報價有效日期、廠商品號） |
| B採購單 / B採購明細 | 採購單主檔 / 明細 |
| B請購需求 | 請購需求單（請購底稿資料來源） |
| B進貨驗收單 / B進退貨驗收明細 | 進退貨驗收 |
| 採購計畫 | 專案零件採購/入庫追蹤總表（週排程系列與採購計畫畫面共用資料源；含 模組名稱/倉管人員/驗收合格/BOM表識別碼/採購識別碼 欄位） |
| 產製單位 | 零件管制報告書「產製單位」下拉來源 |
| 採購零件檢驗履歷 | 零件檢驗履歷相關參考模型 |

### 週排程 (Scheduling) — 新增
| 模型 | 說明 |
|------|------|
| 設計週排程表 / 採購週排程表 / 加工週排程表 | 各排程頁之日期分桶扁平化 DTO |
| 後製程週排程表 | 特殊塑型/精密加工/防變形/表面處理 4 階段 x 2 欄位 DTO |
| 組測週排程表 | 進料排程(P)/加工排程(W) 各週 2 欄 DTO |

### 設計 / 圖面 / 用料 — 新增
| 模型 | 對應資料表 |
|------|-----------|
| 設計派案 | 設計派案主檔（設計人員/圖類/檔名/預計完工日等派工欄位） |
| 設計審查明細 | 設計審查清單表身（整批刪除重建） |
| 設計審查項目表 | 制式審查項目主檔 |
| 專案模組用料清單 | 專案模組用料/組裝派案表頭（組裝人員/開工/預交/完工/結案回報/用途） |
| 專案模組BOM明細 | BOM 明細（表身，隨用料清單整批刪除重建） |
| 模組圖檢查 | 圖類檢查分類主檔 |

### 電控排程 / 程控紀錄 — 新增
| 模型 | 對應資料表 |
|------|-----------|
| 專案電控排程 | 電控排程列表資料源（ProgramControlListControl） |
| M-專案程控排程 / M-專案程控履歷 | 專案機台程控紀錄表下方兩明細清單 |

### 零件管制 / 試機驗收 / 異常矯正 — 新增
| 模型 | 對應資料表 |
|------|-----------|
| 異常矯正措施報告 | 異常矯正措施報告主檔（單號 `ER`+西元年4位+流水號3位） |
| 試機驗收單 | 賣方廠驗收單維護表頭（~60 個欄位 + S1~S10 規格欄位） |
| 專案焊接測試數據 | TEST AND TRIAL PARAMETERS 焊接測試數據（Model + A01~A24） |
| 專案改正措施內容 | 賣方廠驗收單改正措施內容子表（含中文轉譯欄位別名） |

### 財務
| 模型 | 對應資料表 |
|------|-----------|
| F帳款管理 | 應收帳款主檔 |
| F收款 / F收款明細 | 收款單 |
| F付款 / F付款明細 | 付款單（進項憑證登載主檔/明細） |
| F沖款收 / F收支沖帳明細 | 收款單（沖款收）主檔 / 明細 |
| F其他收入單 | 其他收支單 |
| F沖款收 | 沖帳記錄 |
| F幣別 / F匯率 | 幣別匯率設定（匯率設定頁維護） |
| F銀行設定 | 銀行主檔 |
| F銀行明細 | 銀行帳戶明細（存入/支出，供匯入款/月結餘額/明細總覽共用） |
| F資金調節 / 資金調節總覽 | 資金調節單主檔 / 總覽扁平化 DTO |
| F票據異動 | 票據異動主檔 |
| F庫別 | 倉庫別設定 |
| F訂單交易條件 | 交易條件主檔 |
| F總務支出單 / F其他收支明細 | 總務支出單主檔 / 明細（含 detailList 導覽屬性） |
| 總務支出單列表 | 總務支出單總覽列表用扁平化 DTO |
| 付款沖帳總覽 | 付款沖帳總覽列表用扁平化 DTO（60天內/超過60天） |
| 客戶活動力分析 | 業績追蹤（客戶連絡/詢問/報價/訂單統計與成交率）扁平化 DTO |

### 製造 / 物料
| 模型 | 對應資料表 |
|------|-----------|
| 工令單 / 工作紀錄A | 製令主檔 / 製令紀錄 |
| 專案機台交貨單 | 機台交貨單 |
| A材料 | 物料主檔 |
| A機台類型 | 機台類型主檔 |
| Product / ProductSpec | 產品 / 產品規格 |

### 系統 / 權限
| 模型 | 說明 |
|------|------|
| Authenticate | 登入使用者資訊 |
| Menu / MenuSub | 選單結構 |
| Privilege / PrivilegeMenu | 功能權限 |
| A使用者授權 | 使用者功能授權 |
| 模組選單 / 模組子選單 | 角色模組對應 |

---

## 五、維修服務單功能說明

### 流程
```
新增維修服務單
    → 填寫客戶、機台、故障情形、希望服務日期
    → 指派檢修人員（從組測人員清單選取）
    → 選擇服務型態（外派維修 / 後送內修 / 線上指導 / 視訊教學）
    → 儲存 → 系統自動產生單號
    → 填寫查修結果、可能原因、建議更換零件
    → 轉零件申請單（自動填入申請單號）
    → 生效（核准）
```

### 欄位說明
| 區域 | 欄位 |
|------|------|
| 基本資料 | 申請日期、單號、機台型號、客戶簡稱、專案序號、機台類型、機台名稱、客戶名稱、聯絡窗口、維修地點 |
| 右側資訊 | 檢修人員（員工編號+姓名）、服務型態、實際/希望/結案日期、維修服務時數 |
| 故障描述 | 故障情形（多行） |
| 零件轉單 | 轉零件工令 checkbox、開立零件申請單按鈕、零件申請單號 |
| 分析區 | 查修結果（多行）、簡要描述、可能原因+原因類別、建議更換或維修零件、客戶反應 |

---

## 六、供料詢價功能說明

### 流程
```
廠商維護頁（SupplierMaintainControl）
    → 按「供料詢價」按鈕（需已有廠商編號，新廠商須先儲存）
    → 開啟 FrmAddSupplierQuotation 新增視窗，廠商編號唯讀帶入
    → 按品項編號旁放大鏡 → 開 FrmSelectMaterial 彈窗（列出 A材料，可搜尋）
    → 雙擊或按「選取」→ 帶回品項編號 + 自動帶入採購單位
    → 填寫詢價日期、最低/最大採購量（預設 1）、單價、幣別（預設 TWD）、
      詢價人員（下拉，來源為職務="採購"人員）、報價有效日期、廠商品號
    → 按 SAVE → 呼叫 AddSupplierQuotation 寫入 B廠商供料 → 顯示「新增成功」
    → 關閉視窗，回到廠商維護頁並自動刷新供料詢價明細表格（dgvQuotation）
    → 按 EXIT 則不儲存直接關閉
```

### 欄位說明
| 欄位 | 型態 | 說明 |
|------|------|------|
| 廠商編號 | 文字（唯讀） | 由父頁帶入，不可修改 |
| 詢價日期 | 日期 | 預設今日 |
| 品項編號 | 文字（唯讀） | 僅能透過 FrmSelectMaterial 選取寫入 |
| 採購單位 | 文字（唯讀） | 隨品項選取自動帶入（A材料.採購單位，非數字） |
| 最低採購量 / 最大採購量 | 數字 | 預設 1 |
| 單價 | 數字 | 對應 B廠商供料.單價 |
| 幣別 | 下拉 | 來源 F幣別，預設 TWD |
| 詢價人員 | 下拉 | 來源成本單位人員配置 JOIN H員工清冊，職務="採購" AND 編修=1 |
| 報價有效日期 | 日期 | 預設今日 |
| 廠商品號 | 文字 | 廠商自訂料號 |

### 相關檔案
| 檔案 | 位置 |
|------|------|
| FrmAddSupplierQuotation(.Designer).cs | `DigiERP/Forms/Supplier/` |
| FrmSelectMaterial(.Designer).cs | `DigiERP/Forms/Supplier/` |
| FrmSelectContact(.Designer).cs | `DigiERP/Forms/Supplier/`（聯絡人選取，同批一併搬移） |
| SupplierMaintainControl(.Designer).cs | `DigiERP/UserControl/Supplier/SupplierManage/` |
| SupplierController.cs | `MES.WebAPI/Controllers/`（新增 `GetPurchaseStaffList`） |
| SupplierMiddle.cs | `MES.WebAPI/MiddleWare/`（新增 `getPurchaseStaffList`） |

---

## 七、週排程 / 採購追蹤 / 總務支出單功能說明

### 週排程系列流程
```
ProjectScheduleQueryControl（查詢起日 + 第一~六週自動遞增7天）
    → 按 設計/採購/機加工/後製程/組測 按鈕
    → 於頁籤開啟對應 XxxSchedulingControl，帶入日期參數
    → 各頁以 過期(基準日以前)~未來週別 分桶樞紐呈現待處理零件
    → footer 統計每週筆數/可承載量(固定值)/負荷率
```
後製程、組測兩頁不採「日期分桶」，改為「製程階段」或「進料/加工」群組（詳見上方模組表），群組標題以動態計算欄寬對齊。

### 總務支出單流程
```
GeneralExpensesControl（未結案/已結案列表）
    → 點選單號 或 按「新增」
    → 於頁籤開啟 GeneralExpensesMaintainControl
    → 既有單據預設鎖定（唯讀），需按「修改」才能編輯；新增單據直接可編輯
    → 廠商編號：下拉或放大鏡開 FrmSelectSupplier 選取（不彈出跳窗以外的舊式選取視窗）
    → 明細表輸入「原幣未稅」→ 自動帶出「台幣未稅」(×匯率)、「稅額」(×營業稅率)、「金額」(相加)
    → 按「儲存」→ 新增或修改成功後自動關閉頁籤並刷新列表
    → 「覆核」/「取消覆核」切換核准狀態，列印按鈕僅於已覆核後顯示
```

### 請購底稿 / 採購計畫流程
```
ToButListControl（B請購需求 扁平表格，預設整表唯讀）
    → 按「修改」解鎖 → 可新增列或編輯既有列
    → 按「儲存」→ 僅送出實際異動過的列（dirty-row 追蹤），未異動的列不會觸發任何寫入

ProjectProcurementControl（採購計畫 整批瀏覽）
    → 按「修改」解鎖 → 編輯 零件分類/採購人員/實際採購日/預計到貨日/倉管人員/入庫移轉日/驗收結果
    → 按「儲存」→ 僅對上述追蹤欄位送出 SQL UPDATE（不覆寫開工/完工日期等排程共用欄位）
    → 「複式篩選器」→ 開 FrmProjectProcurementFilter（專案序號/模組編碼/零件號碼）→ 確定後套用篩選
```

### 相關檔案
| 檔案 | 位置 |
|------|------|
| ProjectScheduleQueryControl / DesignScheduleControl / ProcurementSchedulingControl / MachiningSchedulingControl / PostProcessSchedulingControl / AssemTestSchedulingControl | `DigiERP/UserControl/Production/`（後五者在 `Scheduling/` 子目錄） |
| GeneralExpensesControl / GeneralExpensesMaintainControl | `DigiERP/UserControl/Accounts/Payment/` |
| ToButListControl | `DigiERP/UserControl/Inventory/ToBuy/` |
| ProjectProcurementControl / FrmProjectProcurementFilter | `DigiERP/UserControl/Inventory/ProjectProcurement/` |
| ExRateRegisterControl | `DigiERP/UserControl/Objective/ExRate/` |
| SalesTrackingControl | `DigiERP/UserControl/Objective/SalesTracking/` |
| ProjectProgressController / ProjectProgressMiddle | `MES.WebAPI/Controllers/` `MES.WebAPI/MiddleWare/` |
| GeneralExpensesController / GeneralExpensesMiddle / GeneralExpensesDataRepository | `MES.WebAPI/Controllers/` `MES.WebAPI/MiddleWare/` `MES.Core/Repository/Impl/` |
| ProjectProcurementController / ProjectProcurementMiddle | `MES.WebAPI/Controllers/` `MES.WebAPI/MiddleWare/` |
| ExRateController / ExRateMiddle | `MES.WebAPI/Controllers/` `MES.WebAPI/MiddleWare/` |
| SalesTrackingController / SalesTrackingMiddle | `MES.WebAPI/Controllers/` `MES.WebAPI/MiddleWare/` |

---

## 八、電控排程 / 試機驗收 / 零件管制 / 異常矯正功能說明（本次開發重點）

### 電控排程流程
```
電控排程列表（ProgramControlListControl，資料源 專案電控排程）
    → 程控人員欄位：Grid-cell 攔截下拉 DropDown 事件 → 改開 FrmSelectStaff 選取回填
    → 點選專案序號（僅檢視模式）→ 開啟(或切換至) ProjectMachineProgramControlRecordControl 頁籤
        → 表頭取自產品規格單 LEFT JOIN 工令單（產品規格單為 WHERE 驅動端，避免右側無資料造成欄位空白）
        → 6 項說明書資料夾項目 checkbox：立即可勾選，勾選後即時 UPDATE 後台資料庫，其餘欄位唯讀
        → 下方兩個 Grid：專案程控排程（沿用電控排程既有後端）、專案程控履歷
```

### 零件管制報告書流程
```
MiscControlOrderControl（表頭資料源：採購計畫）
    → 「零件生產工序」Grid：依製程別（機械加工/特殊塑型/精密加工/防變形/表面處理）帶出對應工作站選項
    → 「零件檢驗履歷」Grid：尺寸精度/幾何精度/材質標準/表面工藝/硬度要求/毛邊修整/微觀裂痕 7 項下拉（合格/特採/重工/報廢/設變）
    → 按「修改」解鎖 → 編輯後「儲存」→ 兩個 Grid 皆為批次 upsert（識別碼=0 新增，否則更新）
    → 「生效」→ 寫入核准/核准日，並自動開啟(或切回)「異常矯正措施報告」頁籤；「取消生效」→ 清空核准/核准日
    → 「修改」在已生效狀態下被擋（提示「請先取消生效」）
```

### 試機驗收單（賣方廠驗收單）流程
```
TestValidationReportControl（總覽，資料源 賣方廠驗收單 聯集 工令單/產品規格單）
    → 按「Add」→ 開啟(或切換至)固定的空白新增頁籤，呼叫 LoadBlank()
    → 點選專案序號 → 開啟(或切換至) TestValidationMaintainControl 對應頁籤，呼叫 LoadData(專案序號)
        → 10 列固定規格 Grid + 專案焊接測試數據／專案改正措施內容 兩個可編輯子表格
        → 「儲存」→ 表頭 upsert（依建檔欄位是否為空判斷新增/修改）+ 改正措施 Grid 批次 upsert
        → 「覆核/取消覆核」→ 寫入/清空核准與核准日，未覆核不可列印
        → 按「列印」→ 先擋「請先完成覆核才能列印」→ 開啟 FrmWeldTestDataEntry（17 個 NumericUpDown 欄位）
          填入焊接測試數據 → 確定並列印 → 儲存數據 → 開啟 FrmTestValidationPrint（3 頁 PDF 預覽/匯出，
          含公司真實 LOGO 圖片、頁碼頁尾，DataGridView 選取藍底遮字問題已透過延遲 BeginInvoke 清除修正）
```

### 異常矯正措施報告流程
```
由「組裝派案及領料作業」結案回報選『設計變更』觸發
    → 依來源單據（去除『售後維修』字樣的製圖檔名）查詢是否已有報告：
        有 → 開啟既有報告；無 → 新建一筆，單號規則 "ER"+西元年4位+流水號3位（getNewAbnormalCorrectionNo，
             於同一交易內以 COUNT(0)+1 計算序號，僅新單且單號為空時產生，避免覆蓋既有單號）
    → 客戶簡稱/機台型號/機台類型/機台名稱唯讀（依專案序號從工令單查詢帶出，不寫回本表）
    → 專案序號改為點選開啟 FrmSelectWorkOrder 選取，不使用鍵盤輸入
```

### 相關檔案
| 檔案 | 位置 |
|------|------|
| ProgramControlListControl(.Designer).cs | `DigiERP/UserControl/Production/ProgramControl/` |
| ProjectMachineProgramControlRecordControl(.Designer).cs | `DigiERP/UserControl/Production/ProjectMachineProgramControlRecord/` |
| MiscControlOrderControl(.Designer).cs / MiscControlReportControl(.Designer).cs | `DigiERP/UserControl/Production/MiscControlReport/` |
| TestValidationReportControl(.Designer).cs / TestValidationMaintainControl(.Designer).cs | `DigiERP/UserControl/Production/TestValidationReport/` |
| FrmWeldTestDataEntry(.Designer).cs / FrmTestValidationPrint(.Designer).cs | `DigiERP/Forms/Production/TestValidationReport/` |
| AbnormalCorrectionReportOverviewControl(.Designer).cs / AbnormalCorrectionReportControl(.Designer).cs | `DigiERP/UserControl/Production/AbnormalCorrectionReportControl/` |
| FrmSelectStaff.cs / FrmSelectWorkOrder.cs | `DigiERP/Forms/Production/` |
| ProjectProgressController / ProjectProgressMiddle | `MES.WebAPI/Controllers/` `MES.WebAPI/MiddleWare/`（本次開發重點所有後端方法均集中於此二檔） |

---

## 九、通用規範

- **日期格式**：所有日期顯示與存取均為 `yyyy/MM/dd`
- **回傳物件**：所有 API 統一使用 `CommonRep<T>`，包含 `result`、`resultList`、`ErrorMessage`、`WorkStatus`
- **讀取鎖定**：`reentrantLock` / `repairLock` 防止並發寫入
- **流水號**：各類單號均透過 DB 查詢最大值(或 COUNT+1)後遞增產生，且僅在新單、單號欄位為空時才於儲存交易內產生（例：`ER`+西元年4位+序號3位、`DA`+yyyyMMdd+序號2位、`BR`+yyyyMM+序號3位）；例外：廠商編號改為人工輸入，`GetSupplierNo` 自動產生已停用
- **修改模式**：客戶簡稱、客戶名稱、申請日期在修改模式下為唯讀
- **廠商編號**：SupplierMaintainControl 新增模式下需人工輸入，儲存前會檢查不可為空（「請輸入廠商編號!」）；`disableControl()` 於檢視模式會鎖定包含供料詢價表格在內的所有欄位與按鈕
- **列表型可編輯表格**（請購底稿、採購計畫等）：一律「唯讀 → 按修改解鎖 → 只送出實際異動過的列（dirty-row 追蹤）」，不是整表重新儲存
- **DataGridViewComboBoxColumn 對應主檔代碼**：主檔欄位常為固定長度字串（含尾端空白），下拉選單的值與資料庫值須 `Trim()` 後比對，並在資料列入清單前檢查是否已存在於 Items、不存在則強制加入，避免「DataGridViewComboBoxCell 值無效」例外；grid 層級再加一道 `DataError` 事件作最後防呆
- **Grid 儲存格內開啟選取彈窗（picker-in-cell）**：於 `DataGridView.EditingControlShowing` 攔截原生 ComboBox 編輯控制項，訂閱其 `DropDown` 事件，透過 `BeginInvoke` 立即關閉原生下拉（`DroppedDown = false`）並改開 `FrmSelectStaff` 等選取視窗，選取結果寫回 `combo.Text`
- **生效/覆核 gating**：寫入或清空「核准」+「核准日」（或對應欄位名稱）；「修改」在已生效/已覆核狀態下一律被擋（提示「請先取消生效」/「請先取消覆核」）
- **DataGridView 之 CellEndEdit 才觸發相依欄位重算**（如原幣未稅→台幣未稅/稅額/金額），需搭配 `CurrentCellDirtyStateChanged` 強制 `CommitEdit`，下拉選定後才會即時觸發 `CellValueChanged`
- **DataGridView 選取藍底覆蓋文字**：`ClearSelection()`/`CurrentCell = null` 必須在控制項已加入可見樹（Handle 已建立）之後才有效，故一律透過 `BeginInvoke` 延後到 Form Load/版面配置完成後執行，重要輸出（如列印用截圖）前再防禦性地清一次
- **PDF 列印**：沿用既有 `FrmEQPShippingPrint` 建立的 PDFsharp（`PackageReference PDFsharp 6.2.4`）慣例——將 Panel `DrawToBitmap` 存為 PNG 再畫入 `XGraphics`；多頁時以多個固定尺寸 Panel 迴圈畫入同一 `PdfDocument`；執行期讀取的圖片資源需在 `.csproj` 明確加 `<None Include>` + `CopyToOutputDirectory=PreserveNewest`（SDK 專案不會自動複製任意檔案）
- **WinForms 容器 Dock 順序**：同層 `Controls.Add` 的呼叫順序決定版面配置解析順序——後加入者的 Dock 先被解析（越晚加入越先卡位），因此 `Dock=Fill` 的控制項務必最先加入，其餘 Top/Bottom 控制項再依序加入
- **TabControl 頁籤寬度**：全域統一改為依文字內容自動縮放（非固定寬度），避免長標題被截斷
- **數值輸入欄位**：性質為數字的欄位（積分點數、工時、焊接測試數據各項參數等）一律使用 `NumericUpDown` 而非 `TextBox`
- **共用查詢區域**：多筆列表查詢統一使用 `List<T>` 一次撈回後於前端 `Where` 篩選（未結案/已結案、複式篩選等），避免每次篩選都重新呼叫 API
- **權限控制**：`chkPrivilege(id)` 於建構子檢查是否可開啟畫面；`chkEditPrivilege(id)` 進一步控制「修改」/「刪除」按鈕是否顯示，已全面套用於各 MaintainControl
