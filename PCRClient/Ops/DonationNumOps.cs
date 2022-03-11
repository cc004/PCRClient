namespace PCRClient.Models;

public partial class EquipDonateResponse : IDonationNum
{
    public int Num => donation_num;
}

public partial class HomeIndexResponse : IDonationNum
{
    public int Num => user_clan.donation_num;
}
