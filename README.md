# MES.Core 專案功能總覽

> 最後更新：2026-07-02　　Branch：master　　Commit：001bbef

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

### 目標管理 (Objective)
| 模組 | 功能說明 |
|------|---------|
| ARWriteOff | 應收帳款核銷作業 |

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
- **客戶資料**：查詢/新增/修改/刪除、客戶聯絡明細、客戶國別、產業代碼
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
| B請購需求 | 請購需求單 |
| B進貨驗收單 / B進退貨驗收明細 | 進退貨驗收 |

### 財務
| 模型 | 對應資料表 |
|------|-----------|
| F帳款管理 | 應收帳款主檔 |
| F收款 / F收款明細 | 收款單 |
| F付款 / F付款明細 | 付款單 |
| F其他收入單 | 其他收支單 |
| F沖款收 | 沖帳記錄 |
| F幣別 / F匯率 | 幣別匯率設定 |
| F銀行設定 | 銀行主檔 |
| F庫別 | 倉庫別設定 |
| F訂單交易條件 | 交易條件主檔 |

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

## 七、通用規範

- **日期格式**：所有日期顯示與存取均為 `yyyy/MM/dd`
- **回傳物件**：所有 API 統一使用 `CommonRep<T>`，包含 `result`、`resultList`、`ErrorMessage`、`WorkStatus`
- **讀取鎖定**：`reentrantLock` / `repairLock` 防止並發寫入
- **流水號**：各類單號均透過 DB 查詢最大值後遞增產生（例外：廠商編號改為人工輸入，`GetSupplierNo` 自動產生已停用）
- **修改模式**：客戶簡稱、客戶名稱、申請日期在修改模式下為唯讀
- **廠商編號**：SupplierMaintainControl 新增模式下需人工輸入，儲存前會檢查不可為空（「請輸入廠商編號!」）；`disableControl()` 於檢視模式會鎖定包含供料詢價表格在內的所有欄位與按鈕
