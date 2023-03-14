var dataTable;

$(document).ready(function () {
    cargarDatatable();
});

function cargarDatatable(){
    dataTable = $("#tblDrivers").DataTable({
        "ajax": {
            "url": "/admin/Drivers/GetAll",
            "type": "GET",
            "datatype": "json",
        },

        "columns": [
            { "data": "id", "width": "auto" },
            { "data": "first_Name", "width": "auto" },
            { "data": "last_Name", "width": "auto" },
            { "data": "ssd", "width": "auto" },
            { "data": "dob", "width": "auto" },
            { "data": "city", "width": "auto" },
            { "data": "address", "width": "auto" },
            { "data": "zip", "width": "auto" },
            { "data": "phone", "width": "auto" },
            { "data": "active", "width": "auto" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/Admin/Drivers/Edit/${data}" class="btn btn-success text-white" style = "cursor:pointer; width:100px">
                                <i class="far fa-edit"></i> Editar
                                </a>
                                &nbsp
                                <a onclic="Delete(/Admin/Drivers/Edit/${data})" class="btn btn-danger text-white" style = "cursor:pointer; width:100px">
                                <i class="far fa-trash-alt"></i>Borrar
                                </a>
                            </div>
                
                    `;
                }, "width": "auto",
            }
        ],
        "language": {

            "decimal": "",
            "emptyTable": "No hay Info",
            "info": "Mostrando _START_ a _END_ de _TOTAL_ Entradas",
            "infoEmpty": "Mostrando 0 to 0 of 0 Entradas",
            "infoFiltered": "(Filtrado de _MAX_ total entradas)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ Entradas",
            "loadingRecords": "Cargando....",
            "processing": "Procesando",
            "search": "Buscar:",
            "zeroRecords": "Sin Resultados",
            "paginate": {
                "first": "Pimero",
                "last": "Último",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        "width":"100%"
    
    });
}
        
