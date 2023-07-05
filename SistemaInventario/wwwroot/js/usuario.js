let dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblDatos').DataTable({
        "language": {
            "lengthMenu": "Mostrar _MENU_ Registros Por Pagina",
            "zeroRecords": "Ningun Registro",
            "info": "Mostrar página _PAGE_ de _PAGES_",
            "infoEmpty": "No se encontraron registros",
            "infoFiltered": "(De: _MAX_ Total Registros)",
            "search": "Buscar",
            "paginate": {
                "first": "Primero",
                "last": "Último",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        "ajax": {
            "url": "/Admin/Usuario/ObtenerTodos"
        },
        "columns": [
            { "data": "email"},
            { "data": "nombres"},
            { "data": "apellidos"},
            { "data": "phoneNumber"},
            { "data": "role"},
            {
                "data": {
                    id: "id", lockoutEnd: "lockoutEnd"
                    },
                "render": function (data) {
                    let hoy = new Date().getTime();
                    let bloqueo = new Date(data.lockoutEnd).getTime();
                    if (bloqueo > hoy) {
                        // el usuario esta bloqueado
                        return `
                        <div class="text-center">
                            <a onclick=Desbloquear('${data.id}') class="btn btn-danger text-white" style="cursor:pointer", width:150px >
                                <i class="bi bi-unlock-fill"></i> Desbloquear
                            </a>
                        </div>
                        `;
                    } else {
                        // el usuario esta desbloqueado
                        return `
                        <div class="text-center">
                            <a onclick=Bloquear('${data.id}') class="btn btn-success text-white" style="cursor:pointer", width:150px >
                                <i class="bi bi-lock-fill"></i> Bloquear
                            </a>
                        </div>
                        `;
                    }
                },
            }
        ]
    });
}

function Bloquear(id) {
    
    swal({
        title: "¿Está seguro de bloquear al usuario?",
        text: "El usuario bloqueado no podrá acceder al sistema.",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((borrar) => {
        if (borrar) {
            $.ajax({
                type: "POST",
                url: '/Admin/Usuario/BloquearDesbloquear',
                data: JSON.stringify(id),
                contentType: "application/json",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}

function Desbloquear(id) {

    swal({
        title: "¿Está seguro de desbloquear al usuario?",
        text: "El usuario desbloqueado podrá acceder al sistema.",
        icon: "success",
        buttons: true,
        dangerMode: true
    }).then((borrar) => {
        if (borrar) {
            $.ajax({
                type: "POST",
                url: '/Admin/Usuario/BloquearDesbloquear',
                data: JSON.stringify(id),
                contentType: "application/json",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}