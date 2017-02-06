using System;

namespace LosTechies.DaysOfRefactoring.PullUpMethod.After
{
	public abstract class Vehicle
	{
		public void Turn(Direction direction)
		{
			// code here
		}
	}

	public class Car : Vehicle
	{
	}

	public class Motorcycle : Vehicle
	{
	}

	public enum Direction
	{
		Left,
		Right
	}

    public  interface Ical
    {
        
         string name { get; set; }
         void getname();
    }
    public  abstract class cal
    {
        public void getname2() { }
        public abstract void getid();
    }
    public class cal2 : cal,Ical
    {
        public string name { get; set; }
        public void getname() { }
        public override void getid()
        {
            
        }
    }
}
