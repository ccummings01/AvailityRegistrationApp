var Register = (function ($) {
    var self = {};
    var init = function () {

        self.urls = {
            saveRegistration:'/api/Registration/joinAvaility',
        }

        self.html = {
            firstNameInput: $('#first'),
            lastNameInput: $('#last'),
            npiInput: $('#NPINumber'),
            phoneInput: $('#phone'),
            emailInput: $('#email'),
            businessAddressInput: $('#BusinessAddress'),
            submitBtn: $('#JoinAvaility'),
            form: $('#join')
        }

        self.registrationObject = { FirstName: '', LastName: '', NPINumber: '', BusinessAddress: '', PhoneNumber: '', EmailAddress: '' }

        self.html.form.submit(function (event) {
            self.registrationObject.FirstName = self.html.firstNameInput.val();
            self.registrationObject.LastName = self.html.lastNameInput.val();
            self.registrationObject.NPINumber = self.html.npiInput.val();
            self.registrationObject.BusinessAddress = self.html.businessAddressInput.val();
            self.registrationObject.PhoneNumber = self.html.phoneInput.val();
            self.registrationObject.EmailAddress = self.html.emailInput.val();
            $.ajax({
                url: self.urls.saveRegistration,
                type: 'Post',
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify(self.registrationObject),
                success: function (data) {
                    // some alert message or redirect
                },
                error: function (message) {
                    // some alert message 
                }
            });
        });
  
    }


  
    return {
        Initialize: init
    }
}(jQuery));