#pragma checksum "C:\Users\Dominic\Documents\GitHub\IS7012\GroceryListManager\GroceryListManager\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3a70d0d0cc7298585b2bac1a8d5e0b55d12450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GroceryListManager.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(GroceryListManager.Pages.Pages_Index), null)]
namespace GroceryListManager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Dominic\Documents\GitHub\IS7012\GroceryListManager\GroceryListManager\Pages\_ViewImports.cshtml"
using GroceryListManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3a70d0d0cc7298585b2bac1a8d5e0b55d12450", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f4313d527d19a5a767e611b069e60e427e98c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Dominic\Documents\GitHub\IS7012\GroceryListManager\GroceryListManager\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 874, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Grocery List</h1>
</div>
<style>
table#grocerylistheader {
    font-family: arial, sans-serif;
    border-collapse: collapse;
    width: 100%;
}

#grocerylistheader td, #grocerylistheader th {
    border: 1px solid #dddddd;
    text-align: left;
    padding: 8px;
}

#grocerylistheader tr:nth-child(even) {
    background-color: #dddddd;
}
</style>
<style>
    table#grocerylist {
        font-family: arial, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

    #grocerylist td, #grocerylist th {
        border: 1px solid #dddddd;
        text-align: left;
        padding: 8px;
    }

    #grocerylist tr:nth-child(even) {
        background-color: #dddddd;
    }
</style>
<div class=""alert"">Loading...</div>

<table id=""grocerylist"" >

</table>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(963, 6749, true);
                WriteLiteral(@"
    <script>
$(function() {
    loadData();

    $(""#grocerylist"").on(""click"", ""#createItem"",
        function () {

            
            var newname = $(""#newname"").val();
            var newquan = $(""#newquantity"").val();
            var newpurch = false;
            if ($(""#newpurchased"").is("":checked"")) {
                newpurch = true;
            };

            var newitem = {
                name: newname,
                quantity: newquan,
                purchased: newpurch,

            }
            console.log($(""#newpurchased"").val());
            //console.log(newname);
            //console.log(newquan);
            console.log(newpurch);
            console.log(newitem);

            $.ajax({
                url: ""/api/items"",
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(newitem),
                method: 'POST'
            }).done(function () {
                loadData();
     ");
                WriteLiteral(@"       }).fail(function () {
                alert(""there wasn an error"");
            });

        });
    });






        function loadData() {
            $.ajax({
                url: ""/api/items"",
                dataType: 'json',
                contentType: 'application/json',
                method: 'GET'
            }).done(function (responseJSON, status, xhr) {
                $(""#grocerylist"").empty();
                $(""#grocerylist"").append('<tr><th>Item</th><th>Quantity</th><th>Purchased</th><th> </th></tr><tr><td><input type=""text"" id=""newname"" /></td><td><input type=""text"" id=""newquantity"" /></td><td><input type=""checkbox"" id=""newpurchased"" /></td><td><button id=""createItem"">Create an Item</button></td></tr>');
                $.each(responseJSON, function (index, item) {

                    $("".alert"").hide();
                    if (item.purchased == false) {
                        $(""#grocerylist"").append('<tr item-id=""' + item.id + '""><td>' + item.name + '</td>");
                WriteLiteral(@"<td>' + item.quantity + '</td><td><input type=""checkbox"" class=""itempurchased"" ></td><td><a href=""#"" class=""item-delete"">delete</a></td></tr>');
                    }
                    else if (item.purchased == true){
                        $(""#grocerylist"").append('<tr item-id=""' + item.id + '""><td>' + item.name + '</td><td>' + item.quantity + '</td><td><input type=""checkbox"" class=""itempurchased"" checked></td><td><a href=""#"" class=""item-delete"">delete</a></td></tr>');
                    }
                        /*if (item.purchased == true) {
                        $(""#"" + item.id).html('<tr item-id=""' + item.id + '"" style=""background-color:green""><td>' + item.name + '</td><td>' + item.quantity + '</td><td><input type=""checkbox"" class=""itempurchased"" checked></td><td><a href=""#"" class=""item-delete"">delete</a></td></tr>');
                    }*/

                });
            }).fail(function(xhr,status,error) {
                console.log(""fail"", xhr, status, error);
                al");
                WriteLiteral(@"ert(""There was an error retrieving the data"");
            });
        }




        function deleteItem(id) {
            $.ajax({
                url: '/api/items/' + id,
                dataType: 'json',
                contentType: 'application/json',
                method: 'DELETE',
            }).done(function(responseData, status, xhr) {
                loadData();
            }).fail(function(xhr, status, error) {
                alert(""There was an error deleting your item"");
            });

        }
        function purchaseItem(id) {

            
            $.ajax({
                    url: '/api/items/' + id,
                    dataType: 'json',
                    contentType: 'application/json',
                    method: 'PUT',
                    
                }).done(function(responseData, status, xhr) {
                    loadData(); // RELOAD THE BOOK DATA
                    if (callback) {
                        callback();
                    }
         ");
                WriteLiteral(@"       }).fail(function(xhr, status, error) {
                    alert(""There was an error saving your book"");
                });
           /* var updateditem;
            $.ajax({
                url: '/api/items/' + id,
                dataType: 'json',
                contentType: 'application/json',
                method: 'GET',
            }).done(function (responseData, status, xhr) {
                $.each(responseJSON, function (index, item) {
                    var newname = item.name;
            var newquan = item.quantity;
                var newpurch = false;
                if (item.purchased == true) {
                    newpurch = false;
                }
                else if (item.purchased == false) {
                    newpurch = true;
                }
            

            var newitem = {
                name: newname,
                quantity: newquan,
                purchased: newpurch,

            }
            console.log(newname);
          ");
                WriteLiteral(@"  console.log(newquan);
            console.log(newpurch);
            console.log(newitem);
                }
                

            $.ajax({
                url: ""/api/items"",
                dataType: 'json',
                contentType: 'application/json',
                data: JSON.stringify(newitem),
                method: 'POST'
            }).done(function () {
                loadData();
            }).fail(function () {
                alert(""there wasn an error"");
            });

                /*if (item.purchased == true) {
                    item.purchased = false
                }
                else if (item.purchased == false) {
                    item.purchased = true
                }X
                loadData();
            }).fail(function(xhr, status, error) {
                alert(""There was an error updating your item"");
            })*/

        }


        $(""#grocerylist"").on('click', 'a.item-delete', function() {

            var id = ");
                WriteLiteral(@"$(this).parents(""tr"").attr('item-id');
            if (confirm(""Are you sure you want to delete this item"")) {
                console.log(id);
                deleteItem(id);
            }
            return false;
        });
        $(""#grocerylist"").on('click', 'input.itempurchased', function() {

            var id = $(this).parents(""tr"").attr('item-id');

            if (confirm(""Are you sure you want to update this item"")) {
                console.log(id);
                
                purchaseItem(id);
            }
            return false;
        });
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
