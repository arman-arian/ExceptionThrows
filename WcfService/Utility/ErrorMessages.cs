using System.ComponentModel;

namespace WcfService.Utility
{
    public enum ErrorMessages
    {
        [Description("پارامترهای ورودی اشتباه است.")] ArgumentsError = 100,
        [Description("ارتباط با بانک اطلاعاتی قطع می باشد")] DatabaseLinkDisconnect,

        [Description("کاربری با اطلاعات درخواستی پیدا نشد")] UserNotFound = 300,
        [Description("کاربری مورد نظر حذف شده است.")] UserDeleted,
    }

}