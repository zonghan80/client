//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class 客戶聯絡人
    {
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        [Required]
        public string 職稱 { get; set; }
        [Required]
        public string 姓名 { get; set; }
        [Required]
        public string Email { get; set; }
        [RegularExpression(@"\d{4}-\d{6}", ErrorMessage = "請輸入正確的手機格式!")]
        public string 手機 { get; set; }
        public string 電話 { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
