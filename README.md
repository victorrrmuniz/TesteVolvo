# TesteVolvo

A aplicação consiste apenas em um CRUD.

Logo na tela inicial, o usuário tem a opção de criar um novo registro e, caso já exista algum, ele pode alterar, excluir ou exibir
detalhes dos registros existentes.

Um registro consiste em três informações diferentes: modelo, ano de fabricação e ano do modelo do veículo.
- Para o modelo, existe um select com 5 modelos diferentes de caminhões, mas os únicos aceitos serão FM e FH;
- Para o ano de fabricação, sempre será salvo o ano atual, portanto campo aparece em tela, porém estará desabilitado e sempre
mostrando o ano atual;
- Para o ano do modelo, só é possível selecionar o ano atual ou subsequente, dessa forma, é exibido um componente select onde 
os únicos anos possível são os dois citados

Para a edição, os campos e formas de validações são as mesmas que para a criação do componente

Para a tela de exclusão do registro é solicitada uma confirmação para que a ação seja executada

Optei por não criar testes unitários utilizando Xunit, por exemplo, pois a aplicação se trata apenas de um CRUD básico. As regras da aplicação são simples, então optei por não valida-las por esse caminho. As validações feitas estão contidas na classe de modelo da aplicação. Todos os campos são obrigatórios. Para o modelo, é feita uma validação para que só sejam aceitos os modelos FH e FM. O ano de fabricação do veículo sempre será o ano atual e o ano do modelo apenas poderá ser o ano atual ou o seguinte.
