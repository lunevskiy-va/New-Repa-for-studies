using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

Invoice_payment Pay_up_bitch=new Invoice_payment(150,15,50,4);
//Console.WriteLine(Pay_up_bitch);

BinaryFormatter binFormat =
 new BinaryFormatter();
using (Stream fStream =
 File.Create("zdorovo_zaebal.bin"))
{
    binFormat.Serialize(fStream, Pay_up_bitch);
}
Console.WriteLine("BinarySerialize OK!");
Invoice_payment p = null;
using (Stream fStream =
File.OpenRead("zdorovo_zaebal.bin"))
{
    p = (Invoice_payment)binFormat.
    Deserialize(fStream);
}
Console.WriteLine(p);

[Serializable]
public class Invoice_payment:ISerializable
{
    public decimal payment_day { get; set; }
    public int day { get; set;}

    public decimal fine { get; set; }
    public int day_delay { get; set; }

    public decimal payment ;
    public decimal amount  ;

    public decimal sum;

    static bool property=true;

    public Invoice_payment() { }
    public Invoice_payment(decimal _payment_day, int _day, decimal _fine, int _day_delay)
    {
        this.payment_day = _payment_day;
        this.day = _day;
        this.fine = _fine;
        this.day_delay = _day_delay;
        this.payment = _payment_day*_day;
        this.amount = _fine*_day_delay;
        this.sum = this.payment + this.amount;
    }

    private Invoice_payment(SerializationInfo info, StreamingContext context)
    {
        if(property==true)
        {
            payment_day = info.GetDecimal("Оплата за день");
            day = info.GetInt32("Количество дней");
            fine = info.GetDecimal("Штраф за один день задержки оплаты");
            day_delay = info.GetInt32("Количество дней задержки оплаты");
            payment = info.GetDecimal("Сумма к оплате без штрафа");
            amount = info.GetDecimal("Штраф");
            sum = info.GetDecimal("Общая сумма к оплате");
        }
        else
        {
            payment_day = info.GetDecimal("Оплата за день");
            day = info.GetInt32("Количество дней");
            fine = info.GetDecimal("Штраф за один день задержки оплаты");
            day_delay = info.GetInt32("Количество дней задержки оплаты");
        }
    }

    void ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
        if (property == true)
        {
            info.AddValue("Оплата за день", payment_day);
            info.AddValue("Количество дней", day);
            info.AddValue("Штраф за один день задержки оплаты", fine);
            info.AddValue("Количество дней задержки оплаты", day_delay);
            info.AddValue("Сумма к оплате без штрафа", payment);
            info.AddValue("Штраф", amount);
            info.AddValue("Общая сумма к оплате", sum);
        }
        else
        {
            info.AddValue("Оплата за день", payment_day);
            info.AddValue("Количество дней", day);
            info.AddValue("Штраф за один день задержки оплаты", fine);
            info.AddValue("Количество дней задержки оплаты", day_delay);
        }
    }
    public override string ToString()
    {
        return $"Счет для оплаты парковки:\nСтоимость парковки за день - {payment_day}\nВы простояли - {day}\nШтраф за один день просрочки -{fine}\nВы просрочили" +
            $"- {day_delay}\nСумма к оплате не включая штраф - {payment}\nШтраф вышел - {amount}\nИтого к оплате: {sum}";
    }

}