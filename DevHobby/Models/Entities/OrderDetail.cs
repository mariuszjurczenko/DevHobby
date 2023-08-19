namespace DevHobby.Models.Entities;

public class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int Amount { get; set; }

    public decimal Price { get; set; }

    public int CourseId { get; set; }

    public Course Course { get; set; } = default!;

    public int OrderId { get; set; }

    public Order Order { get; set; } = default!;
}