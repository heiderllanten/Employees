interface Employee {
    id: number,
    name: string,
    contratTypeName: ContractTypeName,
    hourlySalary: number,
    monthlySalary: number,
    roleId: Role,
    anualSalary: number
}

enum ContractTypeName {
    HourlySalaryEmployee,
    MonthlySalaryEmployee
}