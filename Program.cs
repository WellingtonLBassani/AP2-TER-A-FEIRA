Biblioteca biblioteca = new Biblioteca();

// Cadastrar livros
Livro livro1 = new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", ISBN = "123456", Genero = "Fantasia", QuantidadeEmEstoque = 5, Codigo = "1" };
Livro livro2 = new Livro { Titulo = "1984", Autor = "George Orwell", ISBN = "654321", Genero = "Ficção", QuantidadeEmEstoque = 3, Codigo = "2" };
biblioteca.CadastrarLivro(livro1);
biblioteca.CadastrarLivro(livro2);

// Cadastrar usuários
Usuario usuario1 = new Usuario("Joãozinho", 1, "Rua A, 123", "joao@.com");
Usuario usuario2 = new Usuario("cleitinho", 2, "Rua B, 456", "maria@.com");
biblioteca.CadastrarUsuario(usuario1);
biblioteca.CadastrarUsuario(usuario2);

// Listar livros e usuários
biblioteca.ListarLivros();
biblioteca.ListarUsuarios();

// Emprestar e devolver livro
biblioteca.EmprestarLivro("123456", 1); 
biblioteca.DevolverLivro("1", 1); 

// Exibir o historico de pesquisa de cada usuario
usuario1.ExibirHistorico();
usuario2.ExibirHistorico();
//Exibe as informações do livro
livro2.AdicionarInformações();
//sistema de busca 
biblioteca.PesquisarPorAutor("George Orwell");
biblioteca.PesquisarPorGenero("Ficção");
biblioteca.PesquisarPorTitulo("O Senhor dos Anéis");

