function confirmdelete(EmployeeId, FirstName, MiddleName, LastName, Course, Gender, Phone, Password, Repassword, Address, isDeleteClicked) {
    var deletespan = 'deletespan_' + EmployeeId+FirstName+ MiddleName+LastName+Course+ Gender+ Phone+ Password+ Repassword+ Address;
    var confirmdeletespan = 'confirmdeletespan_' + EmployeeId + FirstName + MiddleName + LastName + Course + Gender + Phone + Password + Repassword + Address;

    if (isDeleteClicked) {
        $('#' + deletespan).hide();
        $('#' + confirmdeletespan).show();
    }
    else {
        $('#' + deletespan).show();
        $('#' + confirmdeletespan).hide();
    }
}