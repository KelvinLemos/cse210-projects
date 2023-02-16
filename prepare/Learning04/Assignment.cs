using System;

class Assignment
{
   // Atributes
   private string _studentName;
   private string _topic;

   //Contructors
   public Assignment(){
    _studentName = "Anonymous";
    _topic = "Unknown";
   }
   public Assignment(string name, string topic)
   {
       this._studentName = name;
       this._topic = topic;
   }

   // Method
   public string GetStudentName()
   {
    return _studentName;
   }
   public string GetSummary()
   {
      return _studentName + " - " +_topic;

   }
   
}
