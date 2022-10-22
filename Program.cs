using System;


public class Student
{
    private int _id;
    private string _name;
    private int _passMark=35;


    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name can not be null or empty");
            }
            this._name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._name) ? "no-name" : this._name;

        }
    }

   // public string GetName()
   // {
       // return string.IsNullOrEmpty(this._name) ? "no-name" : this._name;

        //if (string.IsNullOrEmpty(this._name))
        //{
        //    return "No name";
        //}
        //else
        //{
        //    return this._name;
        //}
   // }
    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Id can not be negative");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }

}
 
public class Program
    {
      public  static void Main()
        {
         Student C1 =new Student();
          C1.Id = 1;
        C1.Name = "Saifullah";

        Console.WriteLine("Student Id ={0} ", C1.Id);
        Console.WriteLine("Student name ={0} ", C1.Name);
        Console.WriteLine("Student Pass marks ={0} ", C1.PassMark);
       
        
        
        //C1.ID = 101;
        //C1.Name = null;
        //C1.PassMark = 0;
        //Console.WriteLine("ID = {0} && Name = {1} && Passmark = {2}",C1.ID,C1.Name,C1.PassMark);
    }
    }
