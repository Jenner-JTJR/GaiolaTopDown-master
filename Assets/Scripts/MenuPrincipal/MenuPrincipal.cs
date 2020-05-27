using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Jogar;
    public GameObject Opcoes;
        public bool OnclickOp = false;
        public GameObject Som;
        public GameObject Musica;
        public GameObject Voltar;
    public GameObject Controle;
        public GameObject ControlesPainel;
        public GameObject VoltarControle;
    public GameObject Sair;
  
    
   

    public void menuPrincipal()
    {
        LeanTween.moveLocal(Menu, new Vector3(0.008f, -1.878f, 1), 0.6f);
        LeanTween.scale(Menu, new Vector3(0.019f, 0.019f, 1), 0.6f).setOnComplete(IniciarJogo);

      
    }
    void IniciarJogo()
    {
        SceneManager.LoadScene(1);
    }
    public void opcoes()
    {
            ZoomIn();
            LeanTween.scale(Jogar, new Vector3(0, 0, 0), 0.2f);
            
            LeanTween.scale(Controle, new Vector3(0, 0, 0), 0.2f);
            
            LeanTween.scale(Sair, new Vector3(0, 0, 0), 0.2f);

            LeanTween.moveLocal(Opcoes, new Vector3(0, -66, 0), 0.5f).setOnComplete(OpcoesClose);
     }
    void OpcoesClose()
    {
        Som.SetActive(true);
        Musica.SetActive(true);
        Voltar.SetActive(true);
        Jogar.SetActive(false);
        Controle.SetActive(false);
        Sair.SetActive(false);
    }
    public void VoltarOpcoes()
    {
        ZoomOut();
            LeanTween.moveLocal(Opcoes, new Vector3(97.2f, -120.84f, 0f), 0.5f).setOnComplete(OpcoesOpen);
            Voltar.SetActive(false);
            Musica.SetActive(false);
            Som.SetActive(false);
            

    }
    public void VoltarControles()
    {
        ZoomOut();
       
        LeanTween.moveLocal(Controle, new Vector3(-99.55499f, -204.3f, 0f), 0.5f);
        LeanTween.scale(ControlesPainel, new Vector3(0, 0, 0), 0.5f);
        ControlesPainel.SetActive(false);
        Jogar.SetActive(true);
        LeanTween.scale(Jogar, new Vector3(1, 1, 1), 0.2f);
        Opcoes.SetActive(true);
        LeanTween.scale(Opcoes, new Vector3(1, 1, 1), 0.2f);
        Sair.SetActive(true);
        LeanTween.scale(Sair, new Vector3(1, 1, 1), 0.2f);
        VoltarControle.SetActive(false);
       
    }
        void OpcoesOpen()
        {
        
        Jogar.SetActive(true);
        LeanTween.scale(Jogar, new Vector3(1, 1, 1), 0.4f);
        Controle.SetActive(true);
        LeanTween.scale(Controle, new Vector3(1, 1, 1), 0.4f);
        Sair.SetActive(true);
        LeanTween.scale(Sair, new Vector3(1, 1, 1), 0.4f);
    }
    public void ControlesOpen()
    {
        Jogar.SetActive(true);
        LeanTween.scale(Jogar, new Vector3(1, 1, 1), 0.4f);
        Opcoes.SetActive(true);
        LeanTween.scale(Controle, new Vector3(1, 1, 1), 0.4f);
        Sair.SetActive(true);
        LeanTween.scale(Sair, new Vector3(1, 1, 1), 0.4f);
    }
    public void controle()
    {
            ZoomIn();
            LeanTween.scale(Jogar, new Vector3(0, 0, 0), 0.2f);

            LeanTween.scale(Opcoes, new Vector3(0, 0, 0), 0.2f);

            LeanTween.scale(Sair, new Vector3(0, 0, 0), 0.2f);

            LeanTween.scale(ControlesPainel, new Vector3 (0 ,0 ,0), 0.2f);
           
            LeanTween.moveLocal(Controle, new Vector3(0, -66, 0), 0.5f).setOnComplete(ControleOpen);

            VoltarControle.SetActive(true);
        }
 
    public void ControleOpen()
    {
        ControlesPainel.SetActive(true);
        LeanTween.scale(ControlesPainel, new Vector3(1, 1, 1), 0.5f);
        Jogar.SetActive(false);
        Opcoes.SetActive(false);
        Sair.SetActive(false);

    }
    public void ZoomIn() {
        LeanTween.moveLocal(Menu, new Vector3(-0.06f, 3.13f, 1), 0.6f);
        LeanTween.scale(Menu, new Vector3(0.019f, 0.019f, 1), 0.6f);
      
    }
    public void ZoomOut()
    {
        LeanTween.moveLocal(Menu, new Vector3(0.01f, 0.01f, 10), 0.6f);
        LeanTween.scale(Menu, new Vector3(0.00751678f, 0.007518565f, 00616676f), 0.6f);
        
    }
}
