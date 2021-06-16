using System;

namespace LibraryFlowersShop
{
    public static class Cheque
    {
        public static string Flm { get; set; }
        public static string Address { get; set; }
        public static string TypeDelivery { get; set; }
        public static string TypePayment { get; set; }
        public static double Price { get; set; }

        public new static string ToString()
        {
            var text = "ФИО: "+ Flm;
            text += Environment.NewLine + "Тип оплаты: " + TypePayment;
            text += Environment.NewLine + "Тип доставки: " + TypeDelivery;
            text += Environment.NewLine + "Адрес доставки: " + Address;
            text += Environment.NewLine;
            text += Environment.NewLine + "Список товаров: ";
            foreach (var flower in Basket.Flowers)
                text += Environment.NewLine + flower.Name + " - " + flower.Price + "руб.";
            text += Environment.NewLine;
            text += Environment.NewLine + "Итог: " + Price + "руб.";
            return text;
        }
}
}
