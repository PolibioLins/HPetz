// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


/*  Validação  Formulário Cadastro   - DOM*/


function validarCadastro(form) {

  caixa_nomeCompleto = document.querySelector('.msgNomeCompleto');
  caixa_cpf = document.querySelector('.msgCpf');
  caixa_dataNascimento = document.querySelector('.msgDataNascimento');
  caixa_email = document.querySelector('.msgEmail');
  caixa_login = document.querySelector('.msgLogin');
  caixa_password = document.querySelector('.msgPassword');
  caixa_rua = document.querySelector('.msgRua');
  caixa_numero = document.querySelector('.msgNumero');
  caixa_bairro = document.querySelector('.msgBairro');
  caixa_cep = document.querySelector('.msgCep');
  

  caixa_nomeCompleto.style.display='none';
  caixa_cpf.style.display='none';
  caixa_dataNascimento.style.display='none';
  caixa_email.style.display='none';
  caixa_login.style.display='none';
  caixa_password.style.display='none';
  caixa_rua.style.display='none';
  caixa_numero.style.display='none';
  caixa_bairro.style.display='none';
  caixa_cep.style.display='none';
  

  if (document.getElementById('nomeCompleto').value=="") {
    caixa_nomeCompleto.innerHTML = "Favor preencher o seu Nome Completo";
    caixa_nomeCompleto.style.display='block';
    document.getElementById('nomeCompleto').focus();
    return false;
  }

   if (document.getElementById('cpf').value == "") {
    caixa_cpf.innerHTML = "Please fill in your Social Security Number:";
    caixa_cpf.style.display = 'block';
    document.getElementById('cpf').focus();
    return false;
  }

   if (document.getElementById('dataNascimento').value == "") {
    caixa_dataNascimento.innerHTML = "Please fill in your Date of birth";
    caixa_dataNascimento.style.display = 'block';
    document.getElementById('dataNascimento').focus();
    return false;
  }

  if (document.getElementById('email').value == "") {
    caixa_email.innerHTML = "Please fill in your e-mail";
    caixa_email.style.display = 'block';
    document.getElementById('email').focus();
    return false;
  }

  if (document.getElementById('login').value == "") {
    caixa_login.innerHTML = "Please fill in your user login";
    caixa_login.style.display = 'block';
    document.getElementById('login').focus();
    return false;
  }

  if (document.getElementById('password').value == "") {
    caixa_password.innerHTML = "Please fill in your password";
    caixa_password.style.display = 'block';
    document.getElementById('password').focus();
    return false;
  }

  if (document.getElementById('rua').value == "") {
    caixa_rua.innerHTML = "Please fill in your street address";
    caixa_rua.style.display = 'block';
    document.getElementById('rua').focus();
    return false;
  }

  if (document.getElementById('numero').value == "") {
    caixa_numero.innerHTML = "Please fill in your house number";
    caixa_numero.style.display = 'block';
    document.getElementById('numero').focus();
    return false;
  }

  if (document.getElementById('bairro').value == "") {
    caixa_bairro.innerHTML = "Please fill in your Boroughs";
    caixa_bairro.style.display = 'block';
    document.getElementById('bairro').focus();
    return false;
  }

  if (document.getElementById('cep').value == "") {
    caixa_cep.innerHTML = "Please fill in your zipcode";
    caixa_cep.style.display = 'block';
    document.getElementById('cep').focus();
    return false;
  }

}

/*  Validação  Formulário Cadastro   - Jquery*/

function validarAgendamento(form) {

  $('.msgNomeTutor').css("display","none");
  $('.msgNomePet').css("display","none");
  $('.msgRaca').css("display","none");
  $('.msgDataHoraAgendamento').css("display","none");
  

  if ($('#nomeTutor').val() =="") {
    $('.msgNomeTutor').text("Please fill in the tutor's name");
    $('.msgNomeTutor').css("display","block");
    $('#nomeTutor').focus();
    return false;
  }

   if ($('#nomePet').val() == "") {
    $('.msgNomePet').text("Please fill in the Pet's name");
    $('.msgNomePet').css("display","block");
    $('#nomePet').focus();
    return false;
  }

   if ($('#raca').val() == "") {
    $('.msgRaca').text("Please fill in the pet's Breed");
    $('.msgRaca').css("display","block");
    $('#raca').focus();
    return false;
  }

  if ($('#dataHoraAgendamento').val() == "") {
    $('.msgDataHoraAgendamento').text("Please fill in the Date and time of the scheduling");
    $('.msgDataHoraAgendamento').css("display","block");
    $('#dataHoraAgendamento').focus();
    return false;
  }


}
