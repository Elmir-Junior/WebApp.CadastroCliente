$(document).ready(function () {
    $('#table').DataTable({
        lengthChange: false,
        language: {
            info: "Mostrando _START_ de _END_ de _TOTAL_ registros",
            search: "Pesquisar: ",
            paginate: {
                first: "Primeiro",
                last: "Final",
                previous: "Voltar",
                next: "Proximo",
            }
        }
    });
});
