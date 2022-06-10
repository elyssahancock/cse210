using System;
public class Phone{
    public long phone_number;
    public List<string> text_messages;

    // Constructor
    Phone(){
        this.phone_number = phone_number;
    }
    public void place_call(long number_to_call){
        Console.WriteLine($"Placing a call to {number_to_call}");
    }//
    
    public void place_text(long number_to_text, string message_to_send){
        Console.WriteLine($"Send {message_to_send} to {number_to_text}");
    }

    public void save_text(string message_to_save){
        Console.WriteLine($"Saved: {message_to_save}");
    }
    public void get_text(){

    }
    public void get_number(){

    }

}

public class CameraPhone : Phone {
    List<string> images = new List<string>();
     public CameraPhone(int phone_number) : base(phone_number)
}




// public CameraPhone(int phone_number) : base(phone_number)


