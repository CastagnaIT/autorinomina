﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace Localization
    
    'Questa classe è stata generata automaticamente dalla classe StronglyTypedResourceBuilder.
    'tramite uno strumento quale ResGen o Visual Studio.
    'Per aggiungere o rimuovere un membro, modificare il file con estensione ResX ed eseguire nuovamente ResGen
    'con l'opzione /str oppure ricompilare il progetto VS.
    '''<summary>
    '''  Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Public Class Resource_WND_Main
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Autorinomina.Resource_WND_Main", GetType(Resource_WND_Main).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Esegue l'override della proprietà CurrentUICulture del thread corrente per tutte le
        '''  ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Enabled.
        '''</summary>
        Public Shared ReadOnly Property Attivato() As String
            Get
                Return ResourceManager.GetString("Attivato", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a PREVIEW.
        '''</summary>
        Public Shared ReadOnly Property Btn_Anteprima() As String
            Get
                Return ResourceManager.GetString("Btn_Anteprima", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Convert to upper/lower case.
        '''</summary>
        Public Shared ReadOnly Property Btn_Menu_ConvertiMaiuscoleMinuscole() As String
            Get
                Return ResourceManager.GetString("Btn_Menu_ConvertiMaiuscoleMinuscole", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a PRESETS.
        '''</summary>
        Public Shared ReadOnly Property Btn_PRESETS() As String
            Get
                Return ResourceManager.GetString("Btn_PRESETS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a RENAME ALL.
        '''</summary>
        Public Shared ReadOnly Property Btn_RinominaTutto() As String
            Get
                Return ResourceManager.GetString("Btn_RinominaTutto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a RESTORE ALL.
        '''</summary>
        Public Shared ReadOnly Property Btn_RipristinaTutto() As String
            Get
                Return ResourceManager.GetString("Btn_RipristinaTutto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a SELECTION.
        '''</summary>
        Public Shared ReadOnly Property Btn_Selezione() As String
            Get
                Return ResourceManager.GetString("Btn_Selezione", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Changing category the files in the list will be removed.\nDo you want to continue?.
        '''</summary>
        Public Shared ReadOnly Property CategoryUserChange() As String
            Get
                Return ResourceManager.GetString("CategoryUserChange", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Date created.
        '''</summary>
        Public Shared ReadOnly Property Column_DataCreazione() As String
            Get
                Return ResourceManager.GetString("Column_DataCreazione", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Date modified.
        '''</summary>
        Public Shared ReadOnly Property Column_DataUltimaModifica() As String
            Get
                Return ResourceManager.GetString("Column_DataUltimaModifica", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Size.
        '''</summary>
        Public Shared ReadOnly Property Column_Dimensione() As String
            Get
                Return ResourceManager.GetString("Column_Dimensione", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Folder.
        '''</summary>
        Public Shared ReadOnly Property Column_NomeCartella() As String
            Get
                Return ResourceManager.GetString("Column_NomeCartella", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Current filename.
        '''</summary>
        Public Shared ReadOnly Property Column_NomeFile() As String
            Get
                Return ResourceManager.GetString("Column_NomeFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a New filename.
        '''</summary>
        Public Shared ReadOnly Property Column_NomeFileRinominato() As String
            Get
                Return ResourceManager.GetString("Column_NomeFileRinominato", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Folder path.
        '''</summary>
        Public Shared ReadOnly Property Column_Percorso() As String
            Get
                Return ResourceManager.GetString("Column_Percorso", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a State.
        '''</summary>
        Public Shared ReadOnly Property Column_Stato() As String
            Get
                Return ResourceManager.GetString("Column_Stato", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Type.
        '''</summary>
        Public Shared ReadOnly Property Column_Tipo() As String
            Get
                Return ResourceManager.GetString("Column_Tipo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Select the folder containing the files to be added.
        '''</summary>
        Public Shared ReadOnly Property Desc_AggiungiCartella() As String
            Get
                Return ResourceManager.GetString("Desc_AggiungiCartella", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Add files or folders by dragging them here or by using the menu..
        '''</summary>
        Public Shared ReadOnly Property Desc_ElencoVuoto() As String
            Get
                Return ResourceManager.GetString("Desc_ElencoVuoto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a DEFINE THE MAIN INFORMATION FOR THE NAMES OF THE FILES.
        '''</summary>
        Public Shared ReadOnly Property DescriptionGuideStructure() As String
            Get
                Return ResourceManager.GetString("DescriptionGuideStructure", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Disabled.
        '''</summary>
        Public Shared ReadOnly Property Disattivato() As String
            Get
                Return ResourceManager.GetString("Disattivato", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a The list of files is empty.
        '''</summary>
        Public Shared ReadOnly Property FileListEmpty() As String
            Get
                Return ResourceManager.GetString("FileListEmpty", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Do not convert.
        '''</summary>
        Public Shared ReadOnly Property MaiuscoleMinuscole_0() As String
            Get
                Return ResourceManager.GetString("MaiuscoleMinuscole_0", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Capitalize words.
        '''</summary>
        Public Shared ReadOnly Property MaiuscoleMinuscole_1() As String
            Get
                Return ResourceManager.GetString("MaiuscoleMinuscole_1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Capitalize words (long only).
        '''</summary>
        Public Shared ReadOnly Property MaiuscoleMinuscole_2() As String
            Get
                Return ResourceManager.GetString("MaiuscoleMinuscole_2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Capitalize sentence (otherwise lower case).
        '''</summary>
        Public Shared ReadOnly Property MaiuscoleMinuscole_3() As String
            Get
                Return ResourceManager.GetString("MaiuscoleMinuscole_3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Capitalize sentence, even after each separator.
        '''</summary>
        Public Shared ReadOnly Property MaiuscoleMinuscole_4() As String
            Get
                Return ResourceManager.GetString("MaiuscoleMinuscole_4", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a All lower case.
        '''</summary>
        Public Shared ReadOnly Property MaiuscoleMinuscole_5() As String
            Get
                Return ResourceManager.GetString("MaiuscoleMinuscole_5", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a All UPPER CASE.
        '''</summary>
        Public Shared ReadOnly Property MaiuscoleMinuscole_6() As String
            Get
                Return ResourceManager.GetString("MaiuscoleMinuscole_6", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Category.
        '''</summary>
        Public Shared ReadOnly Property Menu_Categoria() As String
            Get
                Return ResourceManager.GetString("Menu_Categoria", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a File.
        '''</summary>
        Public Shared ReadOnly Property Menu_File() As String
            Get
                Return ResourceManager.GetString("Menu_File", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Help.
        '''</summary>
        Public Shared ReadOnly Property Menu_Help() As String
            Get
                Return ResourceManager.GetString("Menu_Help", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Edit.
        '''</summary>
        Public Shared ReadOnly Property Menu_Modifica() As String
            Get
                Return ResourceManager.GetString("Menu_Modifica", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a View.
        '''</summary>
        Public Shared ReadOnly Property Menu_Visualizza() As String
            Get
                Return ResourceManager.GetString("Menu_Visualizza", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Add....
        '''</summary>
        Public Shared ReadOnly Property MI_Aggiungi() As String
            Get
                Return ResourceManager.GetString("MI_Aggiungi", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Add files.
        '''</summary>
        Public Shared ReadOnly Property MI_AggiungiDeiFiles() As String
            Get
                Return ResourceManager.GetString("MI_AggiungiDeiFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Add files from favorite folder.
        '''</summary>
        Public Shared ReadOnly Property MI_AggiungiFilesDaCartellaPreferita() As String
            Get
                Return ResourceManager.GetString("MI_AggiungiFilesDaCartellaPreferita", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Add a folder of files.
        '''</summary>
        Public Shared ReadOnly Property MI_AggiungiUnaCartellaDiFiles() As String
            Get
                Return ResourceManager.GetString("MI_AggiungiUnaCartellaDiFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Open.
        '''</summary>
        Public Shared ReadOnly Property MI_Apri() As String
            Get
                Return ResourceManager.GetString("MI_Apri", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Auto-capture clipboard.
        '''</summary>
        Public Shared ReadOnly Property MI_AutoCatturaAppunti() As String
            Get
                Return ResourceManager.GetString("MI_AutoCatturaAppunti", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Change category.
        '''</summary>
        Public Shared ReadOnly Property MI_CambiaCategoria() As String
            Get
                Return ResourceManager.GetString("MI_CambiaCategoria", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Change language.
        '''</summary>
        Public Shared ReadOnly Property MI_CambiaLingua() As String
            Get
                Return ResourceManager.GetString("MI_CambiaLingua", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Load Preset.
        '''</summary>
        Public Shared ReadOnly Property MI_CaricaPreset() As String
            Get
                Return ResourceManager.GetString("MI_CaricaPreset", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Capture files/folders of files.
        '''</summary>
        Public Shared ReadOnly Property MI_CatturaFilesCartelleDiFiles() As String
            Get
                Return ResourceManager.GetString("MI_CatturaFilesCartelleDiFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Capture preset.
        '''</summary>
        Public Shared ReadOnly Property MI_CatturaPreset() As String
            Get
                Return ResourceManager.GetString("MI_CatturaPreset", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Check for updates.
        '''</summary>
        Public Shared ReadOnly Property MI_ControlloAggiornamenti() As String
            Get
                Return ResourceManager.GetString("MI_ControlloAggiornamenti", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Copy Preset.
        '''</summary>
        Public Shared ReadOnly Property MI_CopiaPreset() As String
            Get
                Return ResourceManager.GetString("MI_CopiaPreset", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Select none.
        '''</summary>
        Public Shared ReadOnly Property MI_DeselezionaTutto() As String
            Get
                Return ResourceManager.GetString("MI_DeselezionaTutto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Make a donation.
        '''</summary>
        Public Shared ReadOnly Property MI_Donazione() As String
            Get
                Return ResourceManager.GetString("MI_Donazione", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Exit.
        '''</summary>
        Public Shared ReadOnly Property MI_Exit() As String
            Get
                Return ResourceManager.GetString("MI_Exit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Quick guide.
        '''</summary>
        Public Shared ReadOnly Property MI_GuidaRapida() As String
            Get
                Return ResourceManager.GetString("MI_GuidaRapida", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Settings.
        '''</summary>
        Public Shared ReadOnly Property MI_Impostazioni() As String
            Get
                Return ResourceManager.GetString("MI_Impostazioni", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Include files of subfolders.
        '''</summary>
        Public Shared ReadOnly Property MI_IncludiFilesDelleSottocartelle() As String
            Get
                Return ResourceManager.GetString("MI_IncludiFilesDelleSottocartelle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Paste Preset.
        '''</summary>
        Public Shared ReadOnly Property MI_IncollaPreset() As String
            Get
                Return ResourceManager.GetString("MI_IncollaPreset", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a About Autorinomina.
        '''</summary>
        Public Shared ReadOnly Property MI_InformazioniSuAutoRinomina() As String
            Get
                Return ResourceManager.GetString("MI_InformazioniSuAutoRinomina", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Show toolbar.
        '''</summary>
        Public Shared ReadOnly Property MI_MostraBarraDegliStrumenti() As String
            Get
                Return ResourceManager.GetString("MI_MostraBarraDegliStrumenti", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Show/Hide columns.
        '''</summary>
        Public Shared ReadOnly Property MI_MostraColonne() As String
            Get
                Return ResourceManager.GetString("MI_MostraColonne", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Advanced options.
        '''</summary>
        Public Shared ReadOnly Property MI_OpzioniAvanzate() As String
            Get
                Return ResourceManager.GetString("MI_OpzioniAvanzate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Property.
        '''</summary>
        Public Shared ReadOnly Property MI_Proprietà() As String
            Get
                Return ResourceManager.GetString("MI_Proprietà", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Remove selected.
        '''</summary>
        Public Shared ReadOnly Property MI_RimuoviSelezionati() As String
            Get
                Return ResourceManager.GetString("MI_RimuoviSelezionati", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Remove all.
        '''</summary>
        Public Shared ReadOnly Property MI_RimuoviTutto() As String
            Get
                Return ResourceManager.GetString("MI_RimuoviTutto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Rename selected.
        '''</summary>
        Public Shared ReadOnly Property MI_RinominaSelezionati() As String
            Get
                Return ResourceManager.GetString("MI_RinominaSelezionati", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Restore selected.
        '''</summary>
        Public Shared ReadOnly Property MI_RipristinaSelezionati() As String
            Get
                Return ResourceManager.GetString("MI_RipristinaSelezionati", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Save Preset.
        '''</summary>
        Public Shared ReadOnly Property MI_SalvaPreset() As String
            Get
                Return ResourceManager.GetString("MI_SalvaPreset", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Select all.
        '''</summary>
        Public Shared ReadOnly Property MI_SelezionaTutto() As String
            Get
                Return ResourceManager.GetString("MI_SelezionaTutto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Always on top.
        '''</summary>
        Public Shared ReadOnly Property MI_SempreInPrimoPiano() As String
            Get
                Return ResourceManager.GetString("MI_SempreInPrimoPiano", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Replacing words.
        '''</summary>
        Public Shared ReadOnly Property MI_SostituzioneTermini() As String
            Get
                Return ResourceManager.GetString("MI_SostituzioneTermini", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Move down.
        '''</summary>
        Public Shared ReadOnly Property MI_SpostaInGiu() As String
            Get
                Return ResourceManager.GetString("MI_SpostaInGiu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Move up.
        '''</summary>
        Public Shared ReadOnly Property MI_SpostaInSu() As String
            Get
                Return ResourceManager.GetString("MI_SpostaInSu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Words in Black-list.
        '''</summary>
        Public Shared ReadOnly Property MI_TerminiInBlackList() As String
            Get
                Return ResourceManager.GetString("MI_TerminiInBlackList", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a View status.
        '''</summary>
        Public Shared ReadOnly Property MI_VisualizzaStato() As String
            Get
                Return ResourceManager.GetString("MI_VisualizzaStato", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Complete the current operation or clear the list of files added..
        '''</summary>
        Public Shared ReadOnly Property Msg_AppBusy() As String
            Get
                Return ResourceManager.GetString("Msg_AppBusy", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a To generate the preview add information fields..
        '''</summary>
        Public Shared ReadOnly Property Msg_FileStructureEmpty() As String
            Get
                Return ResourceManager.GetString("Msg_FileStructureEmpty", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a A new version {0} of Autorinomina is available. Do you want to open the web page of downloads?.
        '''</summary>
        Public Shared ReadOnly Property Msg_NewVersion() As String
            Get
                Return ResourceManager.GetString("Msg_NewVersion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a To generate the preview using The TVDB requires an active internet connection..
        '''</summary>
        Public Shared ReadOnly Property Msg_NoInternetConnection() As String
            Get
                Return ResourceManager.GetString("Msg_NoInternetConnection", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a You are using the latest version.
        '''</summary>
        Public Shared ReadOnly Property Msg_NoNewVersion() As String
            Get
                Return ResourceManager.GetString("Msg_NoNewVersion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Remove the selected files from the list?.
        '''</summary>
        Public Shared ReadOnly Property Msg_RimuovereSelezionati() As String
            Get
                Return ResourceManager.GetString("Msg_RimuovereSelezionati", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Remove all files from the list?.
        '''</summary>
        Public Shared ReadOnly Property Msg_RimuovereTutti() As String
            Get
                Return ResourceManager.GetString("Msg_RimuovereTutti", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a There is a new version!.
        '''</summary>
        Public Shared ReadOnly Property NewSWVersion_TitleBar() As String
            Get
                Return ResourceManager.GetString("NewSWVersion_TitleBar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Audio Category.
        '''</summary>
        Public Shared ReadOnly Property Nome_CATEGORIA_audio() As String
            Get
                Return ResourceManager.GetString("Nome_CATEGORIA_audio", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a General Category.
        '''</summary>
        Public Shared ReadOnly Property Nome_CATEGORIA_generica() As String
            Get
                Return ResourceManager.GetString("Nome_CATEGORIA_generica", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Images Category.
        '''</summary>
        Public Shared ReadOnly Property Nome_CATEGORIA_immagini() As String
            Get
                Return ResourceManager.GetString("Nome_CATEGORIA_immagini", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a TV Series Category.
        '''</summary>
        Public Shared ReadOnly Property Nome_CATEGORIA_serietv() As String
            Get
                Return ResourceManager.GetString("Nome_CATEGORIA_serietv", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Video Category.
        '''</summary>
        Public Shared ReadOnly Property Nome_CATEGORIA_video() As String
            Get
                Return ResourceManager.GetString("Nome_CATEGORIA_video", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Preset pasted correctly.
        '''</summary>
        Public Shared ReadOnly Property PresetPasteOk() As String
            Get
                Return ResourceManager.GetString("PresetPasteOk", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Live preview.
        '''</summary>
        Public Shared ReadOnly Property Toggle_AttivaDisattivaLivePreview() As String
            Get
                Return ResourceManager.GetString("Toggle_AttivaDisattivaLivePreview", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Enable/disable replacements.
        '''</summary>
        Public Shared ReadOnly Property Toggle_AttivaDisattivaSostituzioni() As String
            Get
                Return ResourceManager.GetString("Toggle_AttivaDisattivaSostituzioni", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
