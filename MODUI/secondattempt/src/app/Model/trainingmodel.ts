export class Trainingmodel {
    public training_ID:string;
    public training_Name:string;
    public user_ID:string;
    public user_Name:string;
    public mentor_ID:string;
    public mentor_Name:string;
    public skill_ID:string;
    public skill_Name:string;
    public training_StartDate :Date;
    public training_EndDate:Date;
    public training_timeslot:string;
    public training_status:string;
    public training_Progress:string;
    public training_rating:string;
    public training_duration:number;
    public requested:boolean;
    public  rejectNotify:boolean;
    public payment_Status:boolean;

    constructor() {
        this.training_ID="U"+Math.round((Math.random()*9000));
    
        }
}

