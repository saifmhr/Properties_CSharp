using System;


public class Student
{
    private int _id;
    private string _name;
    private int _passMark=35;


    public int PassMarks()
    {
        return this._passMark;
    }
    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name can not be null or empty");
        }
        this._name = Name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._name) ? "no-name" : this._name;

        //if (string.IsNullOrEmpty(this._name))
        //{
        //    return "No name";
        //}
        //else
        //{
        //    return this._name;
        //}
    }
    public void SetID(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Id can not be negative");
        }
        this._id = Id;
    }

    public int GetId()
    {
        return this._id;
    }
}
 
public class Program
    {
      public  static void Main()
        {
         Student C1 =new Student();
          C1.SetID(1);
        C1.SetName("saif");
        Console.WriteLine("Student Id ={0}", C1.GetId());
        Console.WriteLine("Student name ={0}", C1.GetName());
        Console.WriteLine("Student Pass marks ={0}", C1.PassMarks());
        //C1.ID = 101;
        //C1.Name = null;
        //C1.PassMark = 0;
        //Console.WriteLine("ID = {0} && Name = {1} && Passmark = {2}",C1.ID,C1.Name,C1.PassMark);
    }
    }
