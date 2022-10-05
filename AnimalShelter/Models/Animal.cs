using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public DateTime Admit_Date { get; set; }
  }
}