var bootstrapAlert = function (title, message, type = 'secondary', duration = 4900) {

    var ALERT_CONTAINER = '#alert-container'

    var alertEl = $("<div>")
        .addClass("alert alert-" + type)
        .attr('role', 'alert')
        .html('<strong>' + title + ' </strong> ' + message);

    var container = $(ALERT_CONTAINER);

    if (!container.length) {
        var containerEl = $('<div>')
            .attr('id', 'alert-container');

        $('body').append(containerEl);
    }

    $(ALERT_CONTAINER).prepend(alertEl);

    setTimeout(function () {
        alertEl.fadeOut(400, function () {
            alertEl.remove();

            var alerts = $(ALERT_CONTAINER).find('.alert').length;

            if (!alerts) {
                $(ALERT_CONTAINER).remove();
            }
        });
    }, duration)
}


var booksView = (function () {

    var TABLE = '#books';

    var initializeDataTable = function (accessType) {
        $(TABLE).DataTable({
            ajax: {
                url: '/books/getBooks',
                dataSrc: ""
            },
            columns: [
                {
                    data: "name",
                },
                {
                    data: "authorName",
                },
                {
                    data: "genre.name",
                },
                {
                    data: "id",
                    render: (data) => {

                        switch (accessType) {
                            case "View":
                            default:
                                return `<div>
                                            <a href='books/details/${data}' class="btn btn-link btn-sm">
                                                Details
                                            </a>
                                        </div>`;
                            case "Edit":
                                return `<div>
                                            <a href='books/edit/${data}' class="btn btn-link btn-sm">
                                                Edit
                                            </a>
                                            <a href='books/details/${data}' class="btn btn-link btn-sm">
                                                Details
                                            </a>
                                            <button class="btn btn-link btn-sm link-sm remove" data-id="${data}">Remove</button>
                                        </div>`;
                        }
                    },
                },
            ],
        })
    }

    var attachEvents = function (removeCallback) {
        $(TABLE).on("click", "button.remove", function () {
            var id = $(this).data("id");
            removeCallback(id);
        });

        $.fn.dataTable.ext.errMode = 'none';
        $(TABLE).on('error.dt', function (e, settings, techNote, message) {
            bootstrapAlert("DataTable Error", 'An error has been reported by DataTables: ' + message, 'danger', 4900);
        })
            .DataTable();
    }

    var handleRemove = function (id) {
        if (id === undefined) {
            throw new Error("Property name of ID does not exist in current element.")
        }

        var book = $(TABLE)
            .DataTable()
            .rows(function (indx, data) {
                return data.id === id
            }).data()[0];

        bootbox.confirm({
            size: 'small',
            title: 'Confirm remove',
            message: "<p>Do you want to delete book " + book.name+ " ?</p>",
            buttons: {
                confirm: {
                    label: 'Yes',
                    className: 'btn-success btn-sm'
                },
                cancel: {
                    label: 'No',
                    className: 'btn-danger btn-sm'
                }
            },
            callback: function (result) {
                if (result) {

                    fetch("/books/removeBook?id=" + id)
                        .then(function () {
                            var message = "The book was deleted.";
                            bootstrapAlert('Success', message, 'success');
                            $(TABLE).DataTable().ajax.reload();
                        })
                        .catch(function (error) {
                            var message = "An error has occured while removing book"
                            bootstrapAlert('Error', message, 'danger');
                            console.error(error);
                        })
                }
            }
        })
    }

    return {
        initialize: function (accessType) {
            initializeDataTable(accessType);
        },
        attachEvents: function () {
            attachEvents(handleRemove);
        }
    }

})();


var customersView = (function () {

    var TABLE = "#customers";

    var initializeDataTable = function (accessType) {
        $(TABLE).DataTable({
            ajax: {
                url: '/customers/getCustomers',
                dataSrc: ""
            },
            columns: [
                {
                    data: "name",
                },
                {
                    data: "email",
                },
                {
                    data: "membershipType.name",
                    render: function (data) {
                        return `<span>${data}</span>`
                    }
                },
                {
                    data: "birthdate",
                    render: function (data) {
                        return data !== null
                            ? new Date(`${data}`).toDateString()
                            : "-";
                    }
                },
                {
                    data: "id",
                    render: (data) => {
                        if (accessType == "Edit") {
                            return `<div>
                                        <a href='identity/account/edit/${data}' class="btn btn-link btn-sm">
                                            Edit
                                        </a>
                                        <a href='customers/details/${data}' class="btn btn-link btn-sm">
                                            Details
                                        </a>
                                        <button class="btn btn-link btn-sm link-sm remove" data-id="${data}">Remove</button>
                                    </div>`;
                        }
                        else {
                            return `<div>
                                        <a href='customers/details/${data}' class="btn btn-link btn-sm">
                                            Details
                                        </a>
                                    </div>`;
                        }

                    }
                }
            ]
        })
    }

    var attachEvents = function (removeCallback) {
        $(TABLE).on("click", "button.remove", function () {
            var id = $(this).data("id");
            removeCallback(id);
        });

        $.fn.dataTable.ext.errMode = 'none';
        $(TABLE).on('error.dt', function (e, settings, techNote, message) {
            bootstrapAlert("DataTable Error", 'An error has been reported by DataTables: ' + message, 'danger', 5000);
        })
            .DataTable();
    }

    var handleRemove = function (id) {
        if (id === undefined) {
            throw new Error("Property name of ID does not exist.7")
        }

        var account = $(TABLE)
            .DataTable()
            .rows(function (indx, data) {
                return data.id === id
            }).data()[0];

        bootbox.confirm({
            size: 'small',
            title: 'Confirm remove',
            message: "<p>Are you sure to delete account ?",
            buttons: {
                confirm: {
                    label: 'Yes',
                    className: 'btn-success btn-sm'
                },
                cancel: {
                    label: 'No',
                    className: 'btn-danger btn-sm'
                }
            },
           callback: function (result) {
                if (result) {

                    fetch("/customers/remove?id=" + id)
                        .then(function () {
                            var message = "Account was successfully deleted.";
                            bootstrapAlert('Success', message, 'success');
                            $(TABLE).DataTable().ajax.reload();
                        })
                        .catch(function (error) {
                            var message = "An error has occured while removing account.";
                            bootstrapAlert('Error', message, 'danger');
                            console.error(error);
                        })
                }
            }
        })
    }

    return {
        initialize: function (accessType) {
            initializeDataTable(accessType);
        },
        attachEvents: function () {
            attachEvents(handleRemove);
        }
    }

})();