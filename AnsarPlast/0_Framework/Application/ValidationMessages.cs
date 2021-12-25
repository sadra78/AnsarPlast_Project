using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Application
{
    public class ValidationMessages
    {
        public const string IsRequired = "این مقدار نمی تواند خالی باشد.";
        public const string MaxFileSize = "حجم فایل بیشتر از حد مجاز است.";
        public const string MaxInputString = "تعداد کاراکتر های وارد شده بیش از حد مجاز است";

        public const string InvalidFileExtension = "پسوند فایل نامعتر است.";
        public const string MinPassword = "حداقل طول کلمه عبور باید 8 کاراکتر باشد";
    }
}
