﻿using System;
using System.ComponentModel.Design;
using Trabalho.UNDB.PjPort;

string newFile = @"C:\Users\Windows 10\Documents\Trabalho-Csharp\Trabalho-de-Faculdade\Dados\Resister.txt";
// Separador para ser usado.
string separar = "-------------------------------------------------------------------------------";

Import Imp = new Import(newFile);

// Aqui vai fica parte dos projetos onde armazena o Usuário e Senha
List<string> User = new();
List<string> Password = new();

//Contralador da interface no sistema.
bool center_Loop = true;
bool _loop1 = true;
bool _loop2 = true;
bool _loop3 = true;

//Usuário atual
string _user = "";

//Tela inicial de Boas Vindas
Console.WriteLine(separar);
Console.WriteLine("Bem vindo ao controle do porto:");
Console.WriteLine(separar);

//Primeira tela: tela de acesso de 
while (_loop1) {
    //Acessa do usuario, recupera a senha e cadastro.
    Console.WriteLine("Acessa as opções de cadastro");

    //Opções de acesso no qual o usuário possa acessar.
    Console.WriteLine("1- Cadastra\n2-fazer login\n3-Usuarios\n4-esqueceu a senha?\n");

    //Aqui é porcesso de analise do sistema para determinada opção
    int request = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(separar);

    //Aqui resposta de cada opção.
    switch (request) {
        case 1:
            // Inserir os dados de usuario
            Console.Write("Adicionar um Usuário");
            string addUser = Console.ReadLine();
            Console.Write("Adicionar Senha:");
            string addPassaword = Console.ReadLine();
            // Ser adicionado ao banco
            Imp.Save(addUser, addPassaword);
            break;

        case 2:
            //Iserir cadastro do funcionaro
            Console.Write("Escreva seu usuario: ");
            string userCastr = Console.ReadLine();
            Console.Write("Escreva sua senha: ");
            string passCastr = Console.ReadLine();

            //Verififica se a pessoa possui ou não, cadastro:
            if ((User.Contains(userCastr)) && (Password.Contains(passCastr))) {
                Console.WriteLine(separar);
                _user = userCastr;
                _loop1 = false;
            }
            else {
                Console.WriteLine("Usuário não encontrado.");
                Console.WriteLine(separar);
            }
            break;

        case 3:
            string[] user = Imp.Load(newFile);
            //Exibir todos os Usuários cadastrados.
            Console.WriteLine($"Usuários Cadastrados: {user.Length}");
            //imprimir os usuários qu que tem 

            if (user.Length == 0) {
                Console.WriteLine("Nenhum usuario Cadastrado");
            }

            foreach (string line in user) {
                string[] part = line.Split(';');
                string nameUser = part[0];

                Console.WriteLine(nameUser);
            }
            Console.ReadKey();//Aqui segura para usuari ver a opções. 
            Console.WriteLine(separar);
            break;

        //Validação para caso o usuário pense em colocar um valor não selecionado.
        default:
            //Aqui mostra não tem opção para esse valor.
            Console.WriteLine("Opção inválida.");
            Console.WriteLine(separar);
            break;
    }
}

//Tela de usuario: aqui posta o Nome usuario imprimi quais opções ele possui aqui dentro da área.
while (_loop2) {
    // Mensagem de boas vindas.

    //Opções de acesso do usuário




    _loop2 = false;
}

Console.ReadKey();
