

// [HttpGet("getDieselVolDaily/(selDate)")]


// public async Task<IActionResult> getDieselVolDaily(DateTime selDate)
// var credentrials = new NetworkCredential(username, password);
// HttpClientHandler clientHandler = new HttpClientHandler(Credentials = credentrials hi
// clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyerrors) => f return true; | i // access to https
// HttpClient client = new HttpClient(clientHandler);
// DateTime today = DateTime.Now;
// // DateTime month = new DateTime (2022,4,29);
// TimeSpan value = today.Subtract(selDate);
// // TimeSpan value = today.Subtract(month);
// string starttime = Convert.ToString(Convert.ToInt32(value.TotalDays))
// string endtime = Convert.ToString(Convert.ToInt32 (value.TotalDays) -1);
// string itemURL = S@"https://202.44.12.146:1443/piwebapi /streams /F1DP 9bkh7eqdMUSKGa l Dzu9F3wyhUAAAUE 1 TU1 ZcQI AWMS OWMDAWLVMZLURBVEEwMjA / recorded?starttime=*-Istarttime I d&endtime=*-fendtime kd" ;
// HttpResponseMessage response = await client.GetAsync(itemURL);
// string content = await response.Content.ReadAsstringAsync();
// var data = (JArray)JObject.Parse(content)["Items"];
// var result = new List<TagValue>();
// foreach (var item in data)
//     if (item["sood"].Value<bool>() - true)
//         var dataPair = new TagValue()
// Values = item["Value"].Value<string>(),
// TimeStamp = item["Timestamp"].Value<DateTime>()
// result.Add(dataPair);
// return Ok(new(result = result, message = "success"));
// latch(Exception ex)
// return StatusCode(500, new I message = ex.Message));