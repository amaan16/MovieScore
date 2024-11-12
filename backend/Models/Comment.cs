using System;

namespace MovieScore.Models;
public class Comments
{   
    public int Id { get; set;}
    public int Movie_id { get; set;}

    public int User_id {get; set;}

    public string User_name {get;set;}
    public string? Content { get; set;}

}
