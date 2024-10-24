using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraCapture : MonoBehaviour
{
    public Camera captureCamera; // A câmera que fará a captura
    public int imageWidth = 1920; // Largura da imagem
    public int imageHeight = 1080; // Altura da imagem
    public InputField fileNameInput; // Referência ao InputField
    private string nomeFakemon;
    private string descricaoFakemon;
    private string tipoFakemon;
    private RenderTexture renderTexture;
    [System.Serializable]
    public class FakemonData
    {
        public string name; // Nome do Fakemon
        public string description; // Descrição do Fakemon
        public string fileName; // Nome do arquivo da imagem
        public string type; // Tipo do Fakemon
    }

    
    void Start()
    {
        // Criar a RenderTexture com suporte a transparência (RGBA32)
        renderTexture = new RenderTexture(imageWidth, imageHeight, 24, RenderTextureFormat.ARGB32);
        
        // Configurar a câmera para usar essa RenderTexture
        captureCamera.targetTexture = renderTexture;

        // Configurar a cor de fundo da câmera com transparência
        captureCamera.clearFlags = CameraClearFlags.SolidColor;
        captureCamera.backgroundColor = new Color(0, 0, 0, 0); // Fundo transparente
    }
    public void SetNomeFakemon(string nome)
    {
        nomeFakemon = nome;
    } 
    public void SetDescricaoFakemon(string description)
    {
        descricaoFakemon = description;
    }

    public void CaptureImage()
    {
        captureCamera.clearFlags = CameraClearFlags.Nothing;
        captureCamera.Render();

        // Definir a RenderTexture ativa para ler os pixels dela
        RenderTexture.active = renderTexture;

        // Criar uma nova Texture2D com o formato RGBA32 (suporta transparência)
        Texture2D texture = new Texture2D(imageWidth, imageHeight, TextureFormat.RGBA32, false);
        texture.ReadPixels(new Rect(0, 0, imageWidth, imageHeight), 0, 0);
        texture.Apply();

        // Restaurar a configuração original da câmera
        captureCamera.targetTexture = null;
        RenderTexture.active = null;

        // Caminho para salvar a imagem na pasta "Assets/fakemonscapturados"
        string folderPath = Path.Combine(Application.dataPath, "fakemonscapturados");

        // Se a pasta não existir, crie-a
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        string fileName = nomeFakemon; 
        if (string.IsNullOrWhiteSpace(fileName))
        {
            fileName = "FakemonInomeado";
        }
    
        
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"); 
        string filePath = Path.Combine(folderPath, $"{fileName}_{timestamp}.png");
        
        byte[] bytes = texture.EncodeToPNG();

        // Salvar os bytes no arquivo
        File.WriteAllBytes(filePath, bytes);

        Debug.Log("Imagem PNG capturada e salva em: " + filePath);

        FakemonData fakemonData = new FakemonData
        {
            name = nomeFakemon,
            fileName = fileName,
            type = tipoFakemon,
            description = descricaoFakemon, // Exemplo de descrição
        };
        // Liberar memória
        Destroy(texture);
    }
    void Update()
    {

    }
    void OnDisable()
    {
        // Limpar a RenderTexture quando não for mais necessária
        if (renderTexture != null)
        {
            renderTexture.Release();
        }
    }
}