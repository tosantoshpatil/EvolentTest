$(document).ready(function () {
    //$("#btnAdd").click(function () {
    //    document.location = '@Url.Action("Create","ContactInfo")';
    //    //location.href = '@Url.Action("Create","ContactInfo")';
    //})
    $("#btnSave").click(function () {
        debugger;
        var ContactInfo = {};
        ContactInfo.FirstName = $("#txtFname").val();
        ContactInfo.LastName = $("#txtLname").val();
        ContactInfo.Email = $("#txtEmail").val();
        ContactInfo.PhoneNumber = $("#txtMobNo").val();
        $.ajax({
            url: "/ContactInfo/Create",
            type: "post",
            data: JSON.stringify(ContactInfo),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                alert('contact saved successfully');
                window.location.href = '/ContactInfo/Index';

            },
            error: function (error) {

                alert(error);
            }
        })
    })

    $(".lnkedit").click(function () {
        debugger;
        var Row = $(this).parent().parent();
        var EditContactId = $.trim(Row[0].cells[0].innerText);
        window.location.href = '/ContactInfo/EditContact/?ContactId=' + EditContactId;
        return false;

    })


    $(".lnkInactivate").click(function () {
        debugger;
        var Row = $(this).parent().parent();
        var InaAcciveContactId = $.trim(Row[0].cells[0].innerText)
        $.ajax({
            url: '/ContactInfo/InActivatedContact/?ContactId=' + InaAcciveContactId,
            type: 'get',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                debugger;
                alert('contact Inactivate successfully');
                
                Row[0].cells[5].innerText("InActive");
            },
            error: function (error) {

                alert(error);
            }
        })
    })

    $('#btnCancel').click(function () {

        window.location.href = '/ContactInfo/Index';
    })

})