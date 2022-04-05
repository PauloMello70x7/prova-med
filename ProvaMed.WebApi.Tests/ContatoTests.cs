using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ProvaMed.Api;
using ProvaMed.Api.ViewModels;
using ProvaMed.WebApi.Tests.Config;
using Xunit;

namespace ProvaMed.WebApi.Tests
{
    [Collection(nameof(IntegrationApiTestsFixtureCollection))]
    public class ContatoTests
    {
        private readonly IntegrationTestsFixture<Startup> _testsFixture;

        public ContatoTests(IntegrationTestsFixture<Startup> testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Fact(DisplayName = "Add New Contato")]
        [Trait("Category", "Integration API - Contato")]
        public async Task AddContatoWithBooks_MustReturnSuccessfully()
        {


            var Contato = new ContatoViewModel
            {
                Nome = "Paulo Mello",
                DataNascimento = Convert.ToDateTime("19992-11-04"),
                Documento = "111.111.111-11"
            };

            await _testsFixture.LoginApi();
            _testsFixture.Client.AssignToken(_testsFixture.UserToken);

            var postResponse = await _testsFixture.Client.PostAsJsonAsync("api/Contato", Contato);


            postResponse.EnsureSuccessStatusCode();
        }

        [Fact(DisplayName = "Add New Contato Without Document")]
        [Trait("Category", "Integration API - Contato")]
        public async Task AddContatoWithoutDocument_MustReturnUnsuccessfully()
        {


            var Contato = new ContatoViewModel
            {
                Nome = "Paulo Mello",
                DataNascimento = Convert.ToDateTime("1992-11-04"),
                Documento = "",
            };

            await _testsFixture.LoginApi();
            _testsFixture.Client.AssignToken(_testsFixture.UserToken);

            var postResponse = await _testsFixture.Client.PostAsJsonAsync("api/Contato", Contato);


            postResponse.EnsureSuccessStatusCode();
        }

        [Fact(DisplayName = "Update Contato")]
        [Trait("Category", "Integration API - Contato")]
        public async Task UpdateContato_MustReturnSuccessfully()
        {

            var Contato = new ContatoViewModel
            {
                Id = new Guid("13ced886-11e6-4c20-5d52-08d78b471d03"),
                Nome = "Fernando",
                DataNascimento = Convert.ToDateTime("1985-03-04"),
                Documento = "222.222.222-22",
            };

            await _testsFixture.LoginApi();
            _testsFixture.Client.AssignToken(_testsFixture.UserToken);

            var putResponse = await _testsFixture.Client.PutAsJsonAsync($"api/Contato/{Contato.Id}", Contato);

            putResponse.EnsureSuccessStatusCode();
        }

        [Fact(DisplayName = "Delete Contato")]
        [Trait("Category", "Integration API - Contato")]
        public async Task DeleteContato_MustReturnSuccessfully()
        {

            var Contato = new ContatoViewModel
            {
                Id = new Guid("68be4df8-f769-48ac-0b90-08d78b4a6561")
            };

            await _testsFixture.LoginApi();
            _testsFixture.Client.AssignToken(_testsFixture.UserToken);

            var deleteResponse = await _testsFixture.Client.DeleteAsync($"api/Contato/{Contato.Id}");

            deleteResponse.EnsureSuccessStatusCode();
        }

    }
}
