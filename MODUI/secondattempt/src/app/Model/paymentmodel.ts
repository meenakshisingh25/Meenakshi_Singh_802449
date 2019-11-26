export class Paymentmodel {
    public payment_Id:string;
    public payment_amount:string;
   public  user_Id:string;
  public   user_Name:string;
  public  mentor_Id:string;
  public  mentor_Name:string;
   public training_Id:string;
  public  mentor_Amount:string;

  constructor() {
    this.payment_Id="P"+Math.round((Math.random()*9000));
    // this.mentor_Active=true;
}
}
