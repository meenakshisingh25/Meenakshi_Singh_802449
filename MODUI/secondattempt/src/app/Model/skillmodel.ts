export class Skillmodel {

    public skillId:string;
    public skillName:string;
    public tOC:string;
    public prerequisite:string;
    public fee:number;
    public duration:number;

    constructor() {
        this.skillId="U"+Math.round((Math.random()*9000));
}}
