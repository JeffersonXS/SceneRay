# SceneRay

### GitHub dos integrantes

Jefferson Bispo da Silva:
> GitHub [@JeffersonXS](https://github.com/JeffersonXS) &nbsp;&middot;&nbsp;

Lucas Barreto Barbosa:
> GitHub [@LucasBarbosa22](https://github.com/LucasBarbosa22) &nbsp;&middot;&nbsp;

---
### Explicação da cena 

<h4 align ="center">
  Desenvolvemos um projeto no Unity como principal foco criar uma cena 3D com a utilização de elementos de raycast com detector de colisão, com implementação de recursos de iluminação.
</a></h4>
  
* Cenário

  - O ambiente é um local desértico;
  - Nesse lugar nosso personagem treina sua mira com objetos;
  - A cada vez que ele acerta os objetos, vão aparecendo mais em lugares aleatórios dentro do seu campo de visão;
  - É um campo de treino de mira a céu aberto, longe da civilização.

<h1 align="center">
  <a ><img src="https://github.com/JeffersonXS/SceneRay/assets/101645699/d0f3324e-8259-4228-add8-e34a78cd51af" width ="900" </a>
  <br>
</h1>
  
---
* Conceitos de progamação aplicados
  - Raycast;
  - Destroy;
  - Skybox Panoramic;
  - Directional Light;
  - Scripts de movimentação e câmera;
  - Prefab.

### Raycast

  Utilizamos do raycast para definirmos os inimigos e assim criar uma trajetória do nosso personagem até o inimigo. Colocamos uma mira com um canvas, para realmente mostrar se era inimigo ou não, se fosse mostraria a seguinte mensagem no terminal da unity: "hit something". Se não fosse apareceria: "hit nothing".
<h1 align="center">
  <a ><img src="https://github.com/JeffersonXS/SceneRay/assets/101645699/116a8efe-a083-45ca-a43b-c0c45669a8dd" width ="900" </a>
  <br>
</h1>
  
<h1 align="center">
  <a ><img src="https://github.com/JeffersonXS/SceneRay/assets/101645699/d511f3fb-5d50-413d-b5d7-faa5760c4682" width ="900" </a>
  <br>
</h1>
    
### Destroy

  O "destroy" também faz parte do raycast, porque nele definimos a tag do inimigo e, sendo assim, é usado o destroy para acabar com tal.

### Skybox Panoramic

  Aqui ajeitamos a visão do céu, colocando uma imagem png das nuvens em um Material, e utilizamos a opção Environment do lighting localizado no rendering que fica na barra de atalhos Window do unity.

### Directional Light

A "Directional Light" foi usa para a iluminação do cenário, para definirmos uma iluminação mais completa para o cenário. Ao todo ultilizamos 3 delas, uma no céu(con a Skybox) e duas na direção do chão, para aspecto de degradê e um pouco mais claro em direção ao personagem.
  
### Prefab

Foi necessário o "prefab" para fazer com que diversos inimigos surgissem em locais aleatórios sem poluir muito a hierarquia do Unity. Então criamos um script para definir os locais aleatórios, a quantidade e interligamos com o destroy, pois assim que um for destuído um obgjeto determinado com a tag "Inimigo", outro objeto aparece.

<h1 align="center">
  <a ><img src="https://github.com/JeffersonXS/SceneRay/assets/101645699/be154218-4e96-4765-ae97-919ff009b09d" width ="900" </a>
  <br>
</h1>    
  
O seguinte código utilizamos para spawnar os inimigos com prefab:
  
  ```
  
public class spawn : MonoBehaviour
{
    public GameObject Inimigo;
    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-20f, 20f), 1, Random.Range(-0.8f, 50f));
        Instantiate(Inimigo, randomSpawnPosition, Quaternion.identity);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && raycast.Atirado){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-20f, 20f), 1, Random.Range(-0.8f, 50f));
            Instantiate(Inimigo, randomSpawnPosition, Quaternion.identity);
        }
    }
}
  
  ```

### Movimentação e câmera

Além dos scripts de prefab e raycast, criadmos mais dois um para a movimentação básica do personagem como pulo e se mover livremente, tanto na diagonal quanto horizontal e vertical. E outro script foi para ter a câmera em primeira pessoa com liberdade de olhar para diversos cantos.

