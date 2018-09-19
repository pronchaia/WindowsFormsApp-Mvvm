using System;


namespace WindowsFormsApp.Mvvm.Model
{
    public class Form1Model
    {
        public Form1Model()
        {
            Message = "Hello Model";
        }

        public string Message { get; set; }
    }
}
