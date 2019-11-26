export class Usersignupmodel {

    public user_Id:string;
    public user_Name:string;
    public user_Email:string;
    public user_Mobile:string;
    public user_Password:string;

    
    constructor() {
    this.user_Id="U"+Math.round((Math.random()*9000));

    }
}
