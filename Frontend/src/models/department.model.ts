import { Employee } from "./employee.model";

export interface Department {
    departmentId : number;
    name : string;
    description : string;
    establishedDate : Date;
    employees? : Employee[]
}