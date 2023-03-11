' We check which one is active and launch the next one

  Dim xml As String = API.XML()
  Dim x As New System.Xml.XmlDocument
  Dim active As String = ""
  Dim activeNumber As Int32 = 0

  x.LoadXml(xml)
  active = x.SelectSingleNode("//vmix/active").InnerText
  Console.WriteLine(active)

  activeNumber = Convert.ToInt32(active)
  api.Function("Fade", Input:=activeNumber + 1)
