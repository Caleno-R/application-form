Public Class Form1
    Private stdname, regno, school, course As String
    Private yos, sem, cat1, cat2, cat3, assign1, assin2, exam As Integer
    Private totalcats, totalasssig As Integer
    Private average As Double
    Private grade As Char
    Public Property Pcat1()
        Set(value)
            If (value < 0 Or value > 30) Then
                MsgBox("Catmark cannot be less than 0 or greater than 30")
                cat1 = 0
            Else
                cat1 = value
            End If
        End Set
        Get
            Return cat1
        End Get
    End Property
    Public Property Pcat2()
        Set(value)
            If (value < 0 Or value > 30) Then
                MsgBox("Catmark cannot be less than 0 or greater than 30")
                cat1 = 0
            Else
                cat2 = value
            End If
        End Set
        Get
            Return cat1
        End Get
    End Property
    Public Property Pcat3()
        Set(value)
            If (value < 0 Or value > 30) Then
                MsgBox("Catmark cannot be less than 0 or greater than 30")
                cat1 = 0
            Else
                cat3 = value
            End If
        End Set
        Get
            Return cat3
        End Get
    End Property
    Public Property PExam()
        Set(value)
            If (value < 0 Or value > 70) Then
                MsgBox("Catmark cannot be less than 0 or greater than 70")
                exam = 0
            Else
                exam = value
            End If
        End Set
        Get
            Return exam
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtCat1.MaxLength = 2
        txtcat2.MaxLength = 2
        txtcat3.MaxLength = 2
        txtassignment1.MaxLength = 2
        txtassignment2.MaxLength = 2
        txtexam.MaxLength = 2

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSchool.Items.Add("SCIT")
        cboSchool.Items.Add("SPM")
        cboSchool.Items.Add("SAC")
        cboSchool.SelectedIndex = 0
        cboYear.Items.AddRange(New String() {"1", "2"})
        cboYear.SelectedIndex = 0
        cboSem.Items.AddRange(New String() {"1", "2"})
        cboSem.SelectedIndex = 0
    End Sub

    Private Sub cboSchool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSchool.SelectedIndexChanged
        If cboSchool.SelectedIndex = 0 Then
            cboCourse.Items.Clear()
            cboCourse.Items.AddRange(New String() {"Bsc IT", "BBC", "DIT", "CIT"})
            cboCourse.SelectedIndex = 1
        ElseIf cboSchool.SelectedIndex = 1 Then
            cboCourse.Items.Clear()
            cboCourse.Items.AddRange(New String() {"BPM", "BAM", "Statistics"})
            cboCourse.SelectedIndex = 2
        ElseIf cboSchool.SelectedIndex = 2 Then
            cboCourse.Items.Clear()
            cboCourse.Items.Add("Chemistry")
            cboCourse.SelectedIndex = 0

        End If
    End Sub
    Public Sub getdetails()
        stdname = txtNme.Text
        regno = txtRegNo.Text
        school = cboSchool.SelectedItem
        course = cboCourse.SelectedItem
        yos = CInt(cboYear.SelectedItem)
        sem = CInt(cboSem.SelectedItem)
        Pcat1 = CInt(txtCat1.Text)
        Pcat2 = CInt(txtcat2.Text)
        Pcat3 = CInt(txtcat3.Text)
        assign1 = CInt(txtassignment1.Text)
        assin2 = CInt(txtassignment2.Text)
        PExam = CInt(txtexam.Text)


    End Sub
    Public Sub compute()
        totalcats = cat1 + cat2 + cat3
        totalasssig = assign1 + assin2
        average = (totalcats / 3) + ((totalasssig / 2) * 0.01) + PExam
        If average <= 39 Then
            grade = CChar("E")
        ElseIf average <= 49 Then
            grade = CChar("D")
        ElseIf average <= 59 Then
            grade = CChar("C")
        ElseIf average <= 69 Then
            grade = CChar("B")
        Else
            grade = CChar("A")

        End If
    End Sub
    Public Sub printdetails()
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Student Name: " & vbTab & stdname)
        lstOutput.Items.Add("Registraton Number: " & vbTab & regno)
        lstOutput.Items.Add("School: " & vbTab & school & vbTab & "Course: " & vbTab & course)
        lstOutput.Items.Add("Year of Study: " & vbTab & yos & vbTab & "Semester: " & vbTab & sem)
        lstOutput.Items.Add("Grade: " & vbTab & grade)
        lstOutput.Items.Add("Date Printed: " & vbTab & Now)
    End Sub

    Private Sub btnPint_Click(sender As Object, e As EventArgs) Handles btnPint.Click
        getdetails()
        compute()
        printdetails()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
