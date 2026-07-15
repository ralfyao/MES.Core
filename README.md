# DigiERP 專案功能總覽

> 最後更新：2026-07-14　　Branch：master　　Commit：9a03622

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

### 庫存 / 採購 (Inventory) — 新增
| 模組 | 功能說明 |
|------|---------|
| ToButListControl | 請購底稿：`B請購需求` 扁平化可編輯表格，一開始整表唯讀，按「修改」才能新增列/編輯，「儲存」只送出實際異動過的列（dirty-row 追蹤），項目編號/廠商/員工代碼皆有 Trim + 強制塞入下拉清單機制避免資料對不上而拋例外 |
| ProjectProcurementControl | 採購計畫：`採購計畫` 表整批瀏覽與追蹤欄位（零件分類/採購人員/實際採購日/預計到貨日/倉管人員/入庫移轉日/驗收結果）維護，僅對這幾個欄位做 SQL UPDATE（不覆寫開工/完工日期等其他排程欄位，避免影響週排程系列畫面），含「複式篩選器」彈窗（專案序號/模組編碼/零件號碼）與清除篩選 |
| FrmProjectProcurementFilter | 複式篩選彈窗：三個下拉條件（依目前清單資料取不重複值）+ 確定/離開 |

### 會計 / 總務 (Accounts) — 新增
| 模組 | 功能說明 |
|------|---------|
| GeneralExpensesControl | 總務支出單總覽：`F總務支出單` 列表，未結案/已結案篩選、點選單號於頁籤中開啟維護畫面、新增按鈕 |
| GeneralExpensesMaintainControl | 總務支出單維護：廠商編號可用下拉或放大鏡開 `FrmSelectSupplier` 選取、採購人員/幣別匯率/付款條件/採購類別/營業稅率下拉、明細表輸入原幣未稅自動依匯率換算台幣未稅與稅額並加總為金額；新增模式下修改/覆核/取消覆核/列印按鈕隱藏，點開既有單據預設鎖定需按「修改」才能編輯，儲存成功後自動關閉頁籤並刷新列表 |

### 目標管理 (Objective)
| 模組 | 功能說明 |
|------|---------|
| ARWriteOff | 應收帳款核銷作業 |
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

### ProjectProgressController — 新增
- 週排程系列：`GetDesignScheduleList`/`GetProcurementScheduleList`/`GetMachiningScheduleList`/`GetPostProcessScheduleList`/`GetAssemTestScheduleList`，皆以 `採購計畫`（部分含 `B請購需求`/`工令單`）多層 CTE 分桶查詢

### GeneralExpensesController — 新增
- 總務支出單 CRUD：`GetGeneralExpensesList`/`GetGeneralExpensesByNo`/`GetGeneralExpensesNo`/`SaveGeneralExpenses`/`UpdateGeneralExpenses`/`DeleteGeneralExpenses`/`ValidateGeneralExpenses`（覆核/取消覆核）/`GetActiveEmployeeList`（狀況正常之員工）

### ProjectProcurementController — 新增
- `GetProjectProcurementList`（`採購計畫` WHERE 入庫移轉日篩選）、`UpdateProjectProcurement`（僅更新採購追蹤欄位，不動排程用欄位）

### ExRateController — 新增
- `GetAllExRateList`/`SaveExRate`（識別=0 為新增，否則更新）

### SalesTrackingController — 新增
- `GetSalesTrackingList`：客戶活動力分析多層 CTE 統計（起日/迄日區間）

### ProductionController
- 產品/規格管理、工令單 CRUD、工作紀錄、製令查詢

### ItemController
- 材料/物料主檔、分類管理、庫存品項查詢

### StockInController
- 進貨入庫單、倉庫管理、入庫作業

### ARController
- 應收帳款查詢、收款單、付款單、沖帳作業、其他收入/支出

### HRController
- 員工清冊查詢、職務工作分類、成本單位人員配置

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
| **ARMiddle** | 應收帳款計算、收款沖帳、帳款流水號產生 |
| **SupplierMiddle** | 廠商主檔 CRUD、生效/停用、評鑑、聯絡名冊、供料詢價 CRUD、詢價人員查詢（Dapper + Raw SQL 直接組 SQL） |
| **ProjectProgressMiddle** — 新增 | 週排程系列（設計/採購/機加工/後製程/組測）之多層 CTE 分桶查詢，皆以 `採購計畫` 為主資料源 |
| **GeneralExpensesMiddle** — 新增 | 總務支出單 CRUD、單號產生、覆核/取消覆核、狀況正常員工查詢；新增/修改透過 `GeneralExpensesDataRepository`（交易內先刪除單頭+明細再重新寫入） |
| **ProjectProcurementMiddle** — 新增 | 採購計畫清單查詢（含入庫移轉日篩選）、追蹤欄位之局部 SQL UPDATE（刻意不用刪除重建，避免波及週排程共用之其他欄位） |
| **ExRateMiddle** — 新增 | 匯率清單查詢、新增或更新（依識別碼是否為 0 判斷） |
| **SalesTrackingMiddle** — 新增 | 客戶活動力分析多層 CTE 統計（客戶訂單/報價/詢問函/連絡次數、成交率，已修正 COUNT 相除的整數除法截斷問題） |

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
| H職務工作分類 | 職務分類 |
| 成本單位人員配置 | 成本單位人員配置（含職務別） |
| A成本單位 | 成本單位主檔 |

### 採購
| 模型 | 對應資料表 |
|------|-----------|
| B廠商設定 / B廠商聯絡名冊 | 廠商主檔 / 聯絡人 |
| B廠商評鑑 | 廠商評鑑記錄 |
| B廠商供料 | 廠商供料詢價明細（品項、採購單位、最低/最大採購量、單價、幣別、詢價人員、報價有效日期、廠商品號） |
| B採購單 / B採購明細 | 採購單主檔 / 明細 |
| B請購需求 | 請購需求單（請購底稿資料來源） |
| B進貨驗收單 / B進退貨驗收明細 | 進退貨驗收 |
| 採購計畫 | 專案零件採購/入庫追蹤總表（週排程系列與採購計畫畫面共用資料源；新增 模組名稱/倉管人員/驗收合格/BOM表識別碼/採購識別碼 欄位） |

### 週排程 (Scheduling) — 新增
| 模型 | 說明 |
|------|------|
| 設計週排程表 / 採購週排程表 / 加工週排程表 | 各排程頁之日期分桶扁平化 DTO |
| 後製程週排程表 | 特殊塑型/精密加工/防變形/表面處理 4 階段 x 2 欄位 DTO |
| 組測週排程表 | 進料排程(P)/加工排程(W) 各週 2 欄 DTO |

### 財務
| 模型 | 對應資料表 |
|------|-----------|
| F帳款管理 | 應收帳款主檔 |
| F收款 / F收款明細 | 收款單 |
| F付款 / F付款明細 | 付款單 |
| F其他收入單 | 其他收支單 |
| F沖款收 | 沖帳記錄 |
| F幣別 / F匯率 | 幣別匯率設定（匯率設定頁維護） |
| F銀行設定 | 銀行主檔 |
| F庫別 | 倉庫別設定 |
| F訂單交易條件 | 交易條件主檔 |
| F總務支出單 / F其他收支明細 | 總務支出單主檔 / 明細（新增 detailList 導覽屬性） |
| 總務支出單列表 | 總務支出單總覽列表用扁平化 DTO |
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

## 五、維修服務單功能說明（本次開發重點）

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

## 六、供料詢價功能說明（本次開發重點）

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

## 七、週排程 / 採購追蹤 / 總務支出單功能說明（本次開發重點）

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

## 八、通用規範

- **日期格式**：所有日期顯示與存取均為 `yyyy/MM/dd`
- **回傳物件**：所有 API 統一使用 `CommonRep<T>`，包含 `result`、`resultList`、`ErrorMessage`、`WorkStatus`
- **讀取鎖定**：`reentrantLock` / `repairLock` 防止並發寫入
- **流水號**：各類單號均透過 DB 查詢最大值後遞增產生（例外：廠商編號改為人工輸入，`GetSupplierNo` 自動產生已停用）
- **修改模式**：客戶簡稱、客戶名稱、申請日期在修改模式下為唯讀
- **廠商編號**：SupplierMaintainControl 新增模式下需人工輸入，儲存前會檢查不可為空（「請輸入廠商編號!」）；`disableControl()` 於檢視模式會鎖定包含供料詢價表格在內的所有欄位與按鈕
- **列表型可編輯表格**（請購底稿、採購計畫等）：一律「唯讀 → 按修改解鎖 → 只送出實際異動過的列（dirty-row 追蹤）」，不是整表重新儲存
- **DataGridViewComboBoxColumn 對應主檔代碼**：主檔欄位常為固定長度字串（含尾端空白），下拉選單的值與資料庫值須 `Trim()` 後比對，並在資料列入清單前檢查是否已存在於 Items、不存在則強制加入，避免「DataGridViewComboBoxCell 值無效」例外
- **DataGridView 之 CellEndEdit 才觸發相依欄位重算**（如原幣未稅→台幣未稅/稅額/金額），需搭配 `CurrentCellDirtyStateChanged` 強制 `CommitEdit`，下拉選定後才會即時觸發 `CellValueChanged`
- **WinForms 容器 Dock 順序**：同層 `Controls.Add` 的呼叫順序決定版面配置解析順序——後加入者的 Dock 先被解析（越晚加入越先卡位），因此 `Dock=Fill` 的控制項務必最先加入，其餘 Top/Bottom 控制項再依序加入
- **共用查詢區域**：多筆列表查詢統一使用 `List<T>` 一次撈回後於前端 `Where` 篩選（未結案/已結案、複式篩選等），避免每次篩選都重新呼叫 API
