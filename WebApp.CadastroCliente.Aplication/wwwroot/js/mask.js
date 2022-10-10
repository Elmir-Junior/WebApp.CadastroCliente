var cpf = $("#CPF");
var cep = $("#cep");
var data = $("#DataNascimento");

cpf.mask('000.000.000-00', { reverse: true });;
cep.mask('00000-000');
data.mask('00/00/0000');