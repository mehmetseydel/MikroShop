namespace MultiShop.Cargo.EntityLayer.Concrete
{
    public class CargoDetail
    {
        public int CargoDetailId { get; set; }
        public string SenderCustomer { get; set; }//gönderici
        public string ReceiverCustomer { get; set; }//alıcı
        public int Barcode { get; set; }
        public int CargoCompanyId { get; set; }//kargo yurtiçi kargo
        public CargoCompany CargoCompany { get; set; }
    }
}
