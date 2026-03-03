using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 工令單
    {
        [Key]

        public string? 專案序號 { get; set; }
        public string? 訂單日期 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 國家地區 { get; set; }
        public string? 參考序號 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 驗機日期 { get; set; }
        public string? 交貨日期 { get; set; }
        public string? 廠驗 { get; set; }
        public string? 裝機 { get; set; }
        public string? 電流 { get; set; }
        public string? 焊接電壓 { get; set; }
        public string? 焊接電壓v { get; set; }
        public string? 焊接電壓hz { get; set; }
        public string? 焊接物 { get; set; }
        public string? 圖面設計 { get; set; }
        public string? 安規要求 { get; set; }
        public string? 生產速率 { get; set; }
        public string? 結案 { get; set; }
        public string? 建檔 { get; set; }
        public string? 修改 { get; set; }
        public string? 核准 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准日 { get; set; }
        public string? 最大短路電流 { get; set; }
        public string? 變壓器 { get; set; }
        public string? 變壓器數量 { get; set; }
        public string? 焊接模式 { get; set; }
        public string? 焊接壓力ps { get; set; }
        public string? 焊接壓力 { get; set; }
        public string? 夾壓壓力 { get; set; }
        public string? 夾壓壓力數 { get; set; }
        public string? 空氣儲存桶ps { get; set; }
        public string? 空氣儲存桶 { get; set; }
        public string? 啟動方式ps { get; set; }
        public string? 啟動方式 { get; set; }
        public string? 操作控制箱ps { get; set; }
        public string? 操作控制箱 { get; set; }
        public string? 焊接控制器X13ps { get; set; }
        public string? 焊接控制器X13 { get; set; }
        public string? 焊接控制器Y13ps { get; set; }
        public string? 焊接控制器Y13 { get; set; }
        public string? PLC控制器 { get; set; }
        public string? 人機介面ps { get; set; }
        public string? 人機介面 { get; set; }
        public string? 安全門火花檔板 { get; set; }
        public string? 安全光照簾ps { get; set; }
        public string? 安全光照簾 { get; set; }
        public string? 安全柵欄 { get; set; }
        public string? 三色燈ps { get; set; }
        public string? 三色燈 { get; set; }
        public string? 蜂鳴器 { get; set; }
        public string? 焊接氣缸電磁閥 { get; set; }
        public string? 其他氣缸電磁閥 { get; set; }
        public string? 三點組合 { get; set; }
        public string? 其他氣缸 { get; set; }
        public string? 風壓壓力開關 { get; set; }
        public string? 壓力比例閥 { get; set; }
        public string? 氣壓配管 { get; set; }
        public string? 水流浮球 { get; set; }
        public string? 水流水壓 { get; set; }
        public string? 冰水機_熱交換器 { get; set; }
        public string? 入力線方向 { get; set; }
        public string? 無熔絲開關ps { get; set; }
        public string? 無熔絲開關 { get; set; }
        public string? 馬達ps { get; set; }
        public string? 馬達 { get; set; }
        public string? 顏色 { get; set; }
        public string? 儲水槽 { get; set; }
        public string? 上部快速換模 { get; set; }
        public string? 下部模具關閉 { get; set; }
        public string? 下部軸心進出 { get; set; }
        public string? 下部高度調整 { get; set; }
        public string? 輪焊頭尺寸 { get; set; }
        public string? 輪焊頭帶動方式 { get; set; }
        public string? 輪盤車刀 { get; set; }
        public string? 輪盤壓紋 { get; set; }
        public string? 輪盤尺寸 { get; set; }
        public string? 冷卻方式 { get; set; }
        public string? 冷卻水迴路 { get; set; }
        public string? 抽水馬達 { get; set; }
        public string? 焊接方向 { get; set; }
        public string? 側壓壓力數 { get; set; }
        public string? 側壓壓力 { get; set; }
        public string? 油壓比例閥 { get; set; }
        public string? 油壓配管 { get; set; }
        public string? 建檔_工程 { get; set; }
        public string? 修改_工程 { get; set; }
        public string? 核准_工程 { get; set; }
        public string? 建檔日_工程 { get; set; }
        public string? 修改日_工程 { get; set; }
        public string? 核准日_工程 { get; set; }
        public string? 轉設計 { get; set; }
        public string? 建檔_Q { get; set; }
        public string? 修改_Q { get; set; }
        public string? 核准_Q { get; set; }
        public string? 建檔日_Q { get; set; }
        public string? 修改日_Q { get; set; }
        public string? 核准日_Q { get; set; }
        public string? 捲棒送料盤 { get; set; }
        public string? 平板送料系統 { get; set; }
        public string? 捲棒剁料系統 { get; set; }
        public string? 切斷機單機 { get; set; }
        public string? 花式捲棒功能 { get; set; }
        public string? 捲棒料斗寬度 { get; set; }
        public string? 壓平機 { get; set; }
        public string? 說明 { get; set; }
        public string? 備註 { get; set; }
        public string? 客戶名稱 { get; set; }
    }
}
