$(document).ready(function () {
    $('#productTable').DataTable({
        ajax: 'Product/GetAll',
        columns: [
            { data: 'id' },
            { data: 'name' },
            { data: 'description' },
        ],
    });
});