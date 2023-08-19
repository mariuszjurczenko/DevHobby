﻿namespace DevHobby.Models.Entities;

public class Order
{
    public int OrderId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public decimal OrderTotal { get; set; }

    public DateTime OrderPlaced { get; set; }	
    
    public List<OrderDetail>? OrderDetails { get; set; }
}
