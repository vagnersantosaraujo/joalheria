# joalheria
Controle de estoque básico

Desenvolva o código de um software em C# para gerenciar o estoque de produtos de uma joalheria para rodar na plataforma Vscode. O software não irá se conectar ao banco de dados. As informações ficarão em memória, assim, serão perdidas ao reiniciar o programa. 

Assim que o software abrir, ele deve apresentar o seguinte menu: 
[1] Novo 
[2] Listar Produtos 
[3] Remover Produtos 
[4] Entrada Estoque 
[5] Saída Estoque 
[0] Sair 

Ao selecionar o comando [1] Novo, o sistema tem que direcionar o usuário para registrar as seguintes informações:

Informe o tipo da peça:
Nome da peça: 
Preço:
Material:

Depois dessas inserções deve inserir um comando de confirmação do cadastro do produto, retornando ao usuário a seguinte frase: produto cadastrado com sucesso.

O Menu deve ser recursivo. Após a realização da ação escolhida, ele deve voltar a ser apresentado até que seja escolhida a ação [0] Sair.

Ao escolher o comando [2] Listar Produtos, o sistema deve retornar os produtos já cadastrados.

Ao escolher o comando [4] Entrada Estoque, o sistema deve direcionar o usuário para registrar as seguintes informações:

Informar a posição do livro: 
Informar a quantidade de Entrada:

Ao escolher o comando [5] Saída Estoque, o sistema deve direcionar o usuário para registrar as seguintes informações:

Informe a posição do livro:
Informe a quantidade de Saída:

O Menu deve ser recursivo. Após a realização da ação escolhida, ele deve voltar a ser apresentado até que seja escolhida a ação [0] Sair. 
