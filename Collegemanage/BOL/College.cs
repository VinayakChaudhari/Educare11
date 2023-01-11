namespace BOL;
public class College
{
    public int Id{get;set;}
    public string? Name{get;set;}
    public string? Email{get;set;}
    public string? Pin{get;set;}
    public College(int id,string name,string email,string pin){
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.Pin=pin;
    }
}


