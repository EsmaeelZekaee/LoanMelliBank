(function () {
    $(function () {
        var _personService = abp.services.app.person;
        var _$modal = $('#PersonCreateModal');
        var _$form = _$modal.find('form');
        _$form.validate({
            rules: {
                //Password: "required",
                //ConfirmPassword: {
                //    equalTo: "#Password"
                //}
            }
        });
        $('#RefreshButton').click(function () {
            refreshPersonList();
        });
        $('.delete-person').click(function () {
            var personId = $(this).attr("data-person-id");
            var personName = $(this).attr('data-person-name');
            deletePerson(personId, personName);
        });
        $('.edit-person').click(function (e) {
            var personId = $(this).attr("data-person-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'People/EditPersonModal?personId=' + personId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#PersonEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var person = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
            //person.roleNames = [];
            //var _$roleCheckboxes = $("input[name='role']:checked");
            //if (_$roleCheckboxes) {
            //    for (var roleIndex = 0; roleIndex < _$roleCheckboxes.length; roleIndex++) {
            //        var _$roleCheckbox = $(_$roleCheckboxes[roleIndex]);
            //        person.roleNames.push(_$roleCheckbox.val());
            //    }
            //}

            abp.ui.setBusy(_$modal);
            _personService.create(person).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new person!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshPersonList() {
            location.reload(true); //reload page to see new person!
        }

        function deletePerson(personId, personName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'LoanMelliBank'), personName),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _personService.delete({
                            id: personId
                        }).done(function () {
                            refreshPersonList();
                        });
                    }
                }
            );
        }
    });
})();