$(document).ready(function () {
    $("#btnUpdate").click(function () {        
        var ContactInfo = {};
        ContactInfo.ContactId = $('#hdnContactId').val();
        ContactInfo.FirstName = $("#txtFname").val();
        ContactInfo.LastName = $("#txtLname").val();
        ContactInfo.Email = $("#txtEmail").val();
        ContactInfo.PhoneNumber = $("#txtMobNo").val();    
        ContactInfo.Status = $("#chkActive").prop("checked");
        $.ajax({

            url: '/ContactInfo/UpdateContact',
            data: JSON.stringify(ContactInfo),
            type: 'post',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                alert("Contact updated successfully");
                window.location.href = '/ContactInfo/Index';
            },
            error: function (error) {
                alert(error)
            }
        })
    })

    $('#btnCancel').click(function () {
     
        window.location.href = '/ContactInfo/Index';
    })

})