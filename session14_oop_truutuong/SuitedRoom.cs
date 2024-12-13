class SuitedRoom: Room, IWifi{
    private string extraService;
    public string ExtraService{
        get{return extraService;}
        set{extraService = value;}
    }

    private string premiumService;
    public string PremiumService{
        get{return premiumService;}
        set{premiumService = value;}
    }

    public SuitedRoom(
        string roomId, 
        string roomName, 
        double basePrice, 
        string extraService, 
        string premiumService):base(roomId,roomName,basePrice){
            this.extraService = extraService;
            this.premiumService = premiumService;
        }

    public override double calculatePrice()
    {
        return this.BasePrice = this.BasePrice + 200;
    }
        public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Extra Service: {extraService}");
        Console.WriteLine($"Premium Service: {premiumService}");
    } 
    public bool hasWifi(){
        return false;
    }
}