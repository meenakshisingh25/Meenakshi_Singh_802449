export class Mentorsignupmodel {
    public mentor_id:string;
    public mentor_name:string;
    public mentor_Email:string;
    public mentor_Password:string;
    public mentor_ContactNo:string;
    public mentor_exp:string;
    public mentor_Primary_Skill:string;
    public mentor_timeslot:string;
    public mentor_Active:boolean;
    public role:string;
    public mentor_LinkedInUrl:string;
    public mentor_facility:string;

    constructor() {
        this.mentor_id="M"+Math.round((Math.random()*9000));
        this.mentor_Active=true;
}
}