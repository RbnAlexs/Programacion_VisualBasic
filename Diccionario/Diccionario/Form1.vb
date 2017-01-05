Public Class Form1

    Dim opcion As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim count As Integer = (ListBox1.Items.Count - 1)
        Dim words As String
        For a = 0 To count
            words = ListBox1.Items.Item(a)
            If InStr(words.ToLower, TextBox1.Text.ToLower) Then
                ListBox3.Items.Clear()
                ListBox3.Visible = True
                ListBox3.Items.Add(words)
            End If
        Next


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        If MsgBox("Realmente desea salir?", vbYesNo + vbQuestion, "Salida del programa") = vbYes Then
            Close()
        End If


    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            ListBox3.Visible = False
        End If


    End Sub

    Private Sub ListBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged

        opcion = ListBox3.Text
        Seleccionar()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        opcion = ListBox1.Text
        Seleccionar()
    End Sub


    Private Sub Seleccionar()

        Select Case opcion

            Case "Belier o Lop"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\images.jpg"
                Texto.Text = "Formada  a partir de grandes conejos.... " & vbCrLf & "regionales ingleses, esta raza pesa entre 5 y 7 kg. " & vbCrLf & "En el belier inglés original de 1720 se admitían todas las capas. " & vbCrLf & "Otros países adoptaron la raza y la seleccionaron " & vbCrLf & "según sus preferencias, existiendo variedades francesa, " & vbCrLf & "holandesa y alemana entre otras. " & vbCrLf & vbCrLf & "El belier inglés tiene la cabeza grande y ancha de perfil convexo, " & vbCrLf & "orejas largas y caídas a ambos lados de la cabeza y ojos pardos. " & vbCrLf & "Cuello imperceptible, cuerpo bien conformado, " & vbCrLf & " hombros altos, grupa inclinada y extremidades fuertes"

            Case "Californiano o ruso grande"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\ruso.jpg"
                Texto.Text = "Raza formada en California en 1928 por Western con el objetivo  " & vbCrLf & "de crear una raza de doble actitud cárnica-pelo." & vbCrLf & "Para ello se cruzaron conejos de raza rusa con raza chinchilla " & vbCrLf & "y los machos resultantes con hembras de neozelandés " & vbCrLf & "para estabilizar la raza. Capa blanca con ojos rosados  " & vbCrLf & "y pigmentaciones negros en lugares concretos: " & vbCrLf & "orejas, patas y cola.  " & vbCrLf & vbCrLf & "Esto es debido a que la enzima responsable de la pigmentación" & vbCrLf & " negra solo actúa a menos de 30º  " & vbCrLf & "y por tanto en las zonas más frías del cuerpo. " & vbCrLf & "Al no ser albinos son menos  " & vbCrLf & "exigentes en cuanto a temperatura. Pesa entre 4 y 5 kg.  " & vbCrLf & "Cabeza redondeada, orejas largas y erectas con la punta redondeada.  " & vbCrLf & "Cuello corto y grueso con posible papada manifiesta en hembras."

            Case "Chinchilla"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\conejos\chinchilla.jpg"
                Texto.Text = "Raza creada en Francia a partir de conejos silvestres " & vbCrLf & "cruzados con Himalaya y azul de Beveren en 1913 y " & vbCrLf & "mejorada en Alemania al chinchilla gigante en torno a 1920. " & vbCrLf & "No se debe confundir con el roedor chinchilla de Sudamérica" & vbCrLf & "cuyo color da nombre a esta raza. El chinchilla normal " & vbCrLf & "pesa en torno a 3 kg y es usado principalmente por su piel, " & vbCrLf & "siendo su carne algo secundario. Sin embargo las variedades " & vbCrLf & "chinchilla americano (de 4,5 a 5 kg) y el chinchilla gigante " & vbCrLf & "(en torno a 6 kg) son apreciados por su carne." & vbCrLf & "Cabeza mediana y de mayor finura en hembras. " & vbCrLf & "Orejas medianas e inclinadas levemente hacia atrás."


            Case "Gigante de España"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\grandes.jpg"
                Texto.Text = "Creada a principios del siglo XX, está en franca decadencia " & vbCrLf & "desde la introducción de las razas neozelandesa " & vbCrLf & "y californiana en los años 1960, hecho que se " & vbCrLf & "agravó aún más tras la industrialización de la cunicultura " & vbCrLf & "en los 1980, donde la raza estuvo a punto de " & vbCrLf & "desaparecer. Actualmente se está intentando recuperar y " & vbCrLf & "fomentar sus condiciones de rusticidad y como banco de genes. " & vbCrLf & "Capa parda con tonos leonados o grisáceos. " & vbCrLf & "Pesa entre 5 y 8 kg."


            Case "Gigante de Flandes"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\grande.jpg"
                Texto.Text = "Raza muy antigua, datada del siglo XVI. " & vbCrLf & "Fue formada en Bélgica, en la región de Flandes, " & vbCrLf & "a partir de conejos regionales. Pelo corto y liso " & vbCrLf & "de color gris-marrón aunque se admiten diversas " & vbCrLf & "variedades, desde albino con ojos rojos hasta negro, " & vbCrLf & "pasando por una gran gama de grises y azules. Pesa " & vbCrLf & "entre 6 y 8 kg, siendo una efectiva raza mejoradora " & vbCrLf & "de tamaño. Cabeza redondeada de perfil recto, " & vbCrLf & "orejas largas, anchas y erectas acabadas " & vbCrLf & "en punta redondeada."


            Case "Liebre Belga"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\conejos\belga.jpg"
                Texto.Text = "Aparece en Bélgica alrededor de 1880 a partir de " & vbCrLf & "cruzamientos de gigante de Flandes. En un principio " & vbCrLf & "sólo existía la capa rojo agoutí pero actualmente " & vbCrLf & "los criadores han introducido las capas rojo intenso " & vbCrLf & "acanelado (pelos negros dispersos por todo el cuerpo) " & vbCrLf & "y albino. En cualquier caso el pelo es muy brillante. " & vbCrLf & vbCrLf & "Su peso ronda los 3 a 4 kg. Su cuerpo delgado y arqueado, " & vbCrLf & "sus largas orejas y su enérgico temperamento dan a " & vbCrLf & "la raza el pseudónimo de liebre a pesar de ser un " & vbCrLf & "conejo doméstico. "

            Case "Mariposa Francés"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\frances.jpg"
                Texto.Text = "Raza originada en el siglo XIX a partir " & vbCrLf & "de una mutación de gigante de Flandes en Francia. " & vbCrLf & "Su capa es blanca con manchas negras esparcidas, " & vbCrLf & "algunas en lugares concretos: una raya negra " & vbCrLf & "que recubre todo el dorso, orejas negras, " & vbCrLf & "unos círculos negros alrededor de los ojos y " & vbCrLf & "una mancha en la nariz. Los particulares rasgos " & vbCrLf & "de su cara recuerdan a los de una mariposa, " & vbCrLf & "de donde recibe su nombre. El tercio posterior del " & vbCrLf & "animal está repleto de manchas negras. También " & vbCrLf & "existen la capa mariposa habana y mariposa azul, " & vbCrLf & "aparte de la ya descrita mariposa negra. " & vbCrLf & "Pesa entre 3,5 y 4 kg aunque la variedad " & vbCrLf & "mariposa gigante francés puede llegar a sobrepasar " & vbCrLf & "los 6 kg. Los ojos son castaños, orejas erectas y gruesas, " & vbCrLf & "cuello con papada abundante. "

            Case "Neozelandés"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\neo.jpg"
                Texto.Text = "Conejo muy extendido por todo el mundo al que " & vbCrLf & "incluso se puede considerar de doble actitud " & vbCrLf & "carne-pelo. Nacido en 1912 en Estados Unidos con la función " & vbCrLf & "de producir carne. En un principio la única capa " & vbCrLf & "era leonada pero los cruzamientos posteriores " & vbCrLf & "con blanco americano y angora dieron la variedad " & vbCrLf & "blanca tan cotizada por los peleteros por la facilidad " & vbCrLf & "que tiene de ser teñida, y los cruces con la raza " & vbCrLf & "chinchilla dieron lugar a la variedad negra. El pelo " & vbCrLf & "es suave y brillante en todas las variedades. " & vbCrLf & vbCrLf & "Pesa entre 4 y 5 kg. Cabeza redonda y orejas " & vbCrLf & "erguidas con la punta redondeada. Cuello corto " & vbCrLf & "y grueso como es habitual en razas destinadas a carne. " & vbCrLf & "Presencia de papada en hembras. Las hembras son " & vbCrLf & "muy fértiles, producen abundante leche y son buenas " & vbCrLf & "madres."

            Case "Ruso o Himalaya"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\himalaya.jpg"
                Texto.Text = "Pesa de 2 a 2,5 kg aunque se ha obtenido una raza " & vbCrLf & "de iguales características pero de mayor peso " & vbCrLf & "llamado gigante ruso. Tiene el pelo corto " & vbCrLf & "y fino. Su capa es blanca pura con la nariz, orejas, " & vbCrLf & "patas y cola de color negro. Cabeza corta y " & vbCrLf & "ancha en machos, algo más alargada en hembras. " & vbCrLf & "Orejas finas y cortas, muy próximas entre sí y " & vbCrLf & "echadas levemente hacia adelante. Su carne es " & vbCrLf & "de excelente calidad."


            Case "Satín"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\satin.jpg"
                Texto.Text = "Raza originaria de EE.UU. durante la primera " & vbCrLf & "mitad del siglo XX a partir de una mutación en " & vbCrLf & "una camada de raza Habana. Debido a una mutación, " & vbCrLf & "su vello exterior posee una cubierta cristalina " & vbCrLf & "que le otorga un intenso brillo a su capa. Todas las " & vbCrLf & "capas están aceptadas en esta raza. Su peso oscila " & vbCrLf & "entre 3 y 3,5 kg. Es una raza que puede ser usada " & vbCrLf & "de triple actitud carne-pelo-piel."

            Case "Abisinio"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\abisinio.jpg"
                Texto.Text = "El gato Abisinio como todas las razas naturales o " & vbCrLf & "antiguas tiene un pasado incierto. Se cree que " & vbCrLf & "provienen de Abisinia (actualmente Etiopía) y que " & vbCrLf & "descienden de una de las variedades de gatos " & vbCrLf & "presentes en el Antiguo Egipto. En 1860 habrían sido " & vbCrLf & "llevados a Inglaterra, y luego al resto del mundo. " & vbCrLf & "Otra versión refiere que es una raza creada en " & vbCrLf & "Inglaterra a partir de gatos con pelaje jaspeado " & vbCrLf & "(Tickiado). Actualmente es una de las razas " & vbCrLf & "más populares en USA."

            Case "Angora turco"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\angora.jpg"
                Texto.Text = "Los gatos de angora fueron los primeros gatos pelilargos " & vbCrLf & "introducidos en Europa; esto sucedió en el siglo xvi. " & vbCrLf & "" & vbCrLf & "Se importaron de la ciudad del mismo nombre en Turquía " & vbCrLf & "(ahora Ankara), la misma que produjo la cabra de " & vbCrLf & "angora, conocida por su lana extremadamente suave, " & vbCrLf & "y conocida como lana mohair. El gato conquistó " & vbCrLf & "rápidamente a los aficionados."

            Case "Asiatico Humo Atigrado"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\asiatico.jpg"
                Texto.Text = "El Asiático Humo fue desarrollado primero en Gran Bretaña, " & vbCrLf & "bajo el nombre de Burmoire. Este gato, aunque tiene " & vbCrLf & "algunas marcas atigradas, no tiene el pelaje de rayas " & vbCrLf & "de colores normal del atigrado. Los colores del " & vbCrLf & "pelaje pueden ser de cualquiera dentro de la misma " & vbCrLf & "gama que el Burmilla, incluso aquellos con la " & vbCrLf & "restricción del color tipo Birmano, con un pelaje " & vbCrLf & "interno blanco plateado o cercano al blanco."

            Case "Azul Ruso"
                PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\asiatico.jpg"


        End Select


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ListBox1.Items.Clear()
        Texto.Text = "Si tienes un conejo y un gato que andan libremente " & vbCrLf & "por tu casa, sobre todo en los primeros días, " & vbCrLf & "deberás observar cómo se comportan el uno con " & vbCrLf & "el otro. Es habitual que el gato intente ejercer " & vbCrLf & "su rol de animal dominante, intentando cazar al " & vbCrLf & "conejo por ejemplo, lo cual podría agravarse si " & vbCrLf & "éste echa a correr pues el gato lo vería " & vbCrLf & "inmediatamente como una presa a la que hay que " & vbCrLf & "perseguir. No obstante, muchas veces ocurre que los " & vbCrLf & "conejos, principalmente si son de gran tamaño, " & vbCrLf & "se enfrenten al gato y entonces la situación se " & vbCrLf & "invertiría. Los conejos están acostumbrados a pelear " & vbCrLf & "con sus congéneres, tal vez sea el motivo por el cual no " & vbCrLf & "suelen amedrentarse ante los gatos. De cualquier modo, " & vbCrLf & "el consejo a seguir es estar muy atento cuando " & vbCrLf & "ambos estén juntos para lograr, con paciencia y " & vbCrLf & "con tiempo, una convivencia pacífica. "
        PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\cyggg.jpg"

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Texto.Text = "Si tienes un conejo y un gato que andan libremente " & vbCrLf & "por tu casa, sobre todo en los primeros días, " & vbCrLf & "deberás observar cómo se comportan el uno con " & vbCrLf & "el otro. Es habitual que el gato intente ejercer " & vbCrLf & "su rol de animal dominante, intentando cazar al " & vbCrLf & "conejo por ejemplo, lo cual podría agravarse si " & vbCrLf & "éste echa a correr pues el gato lo vería " & vbCrLf & "inmediatamente como una presa a la que hay que " & vbCrLf & "perseguir. No obstante, muchas veces ocurre que los " & vbCrLf & "conejos, principalmente si son de gran tamaño, " & vbCrLf & "se enfrenten al gato y entonces la situación se " & vbCrLf & "invertiría. Los conejos están acostumbrados a pelear " & vbCrLf & "con sus congéneres, tal vez sea el motivo por el cual no " & vbCrLf & "suelen amedrentarse ante los gatos. De cualquier modo, " & vbCrLf & "el consejo a seguir es estar muy atento cuando " & vbCrLf & "ambos estén juntos para lograr, con paciencia y " & vbCrLf & "con tiempo, una convivencia pacífica. "
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Animal.SelectedIndexChanged

        If Animal.Text = "Gatos" Then

            Me.ListBox1.Items.Clear()
            With ListBox1.Items
                .Add("Abisinio")
                .Add("Angora turco")
                .Add("Asiatico Humo Atigrado")
                .Add("Azul Ruso")
                .Add("Balines")
                .Add("Bengal o gato bengali")
                .Add("Bobtail Japones")
                .Add("Gato pantera")

            End With
            Texto.Text = "El gato o gato doméstico (Felis silvestris catus) " & vbCrLf & "es un pequeño mamífero carnívoro de la familia " & vbCrLf & "Felidae. El gato está en convivencia cercana al " & vbCrLf & "ser humano desde hace unos 9.500 años,1 periodo " & vbCrLf & "superior al estimado anteriormente, que oscilaba " & vbCrLf & "entre 3.500 y 8.000 años. Los nombres actuales más " & vbCrLf & "generalizados derivan del latín vulgar catus, palabra " & vbCrLf & "que aludía especialmente a los gatos salvajes en " & vbCrLf & "contraposición a los gatos domésticos que, en latín, " & vbCrLf & "eran llamados felis."
            PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\cat.jpg"

        End If

        If Animal.Text = "Conejos" Then
            Me.ListBox1.Items.Clear()
            With ListBox1.Items
                .Add("Belier o Lop")
                .Add("Californiano o ruso grande")
                .Add("Chinchilla")
                .Add("Gigante de España")
                .Add("Gigante de Flandes")
                .Add("Liebre Belga")
                .Add("Mariposa Francés")
                .Add("Neozelandés")
                .Add("Ruso o Himalaya")
                .Add("Satín")
            End With
            Texto.Text = "Los lepóridos (Leporidae, del latín lepus, liebre),  " & vbCrLf & "conocidos popularmente como conejos y liebres, son  " & vbCrLf & "una familia de mamíferos lagomorfos que  " & vbCrLf & "engloba a una cincuentena de especies agrupadas  " & vbCrLf & "en 11 géneros. El conejo europeo (Oryctolagus cuniculus)  " & vbCrLf & "es la especie más difundida en el mundo y  " & vbCrLf & "la única que ha sido domesticada por el hombre."
            PictureBox1.ImageLocation = "C:\Documents and Settings\Byen\Mis documentos\Mis imágenes\Conejos\portada.png"
        End If


    End Sub



    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


End Class
