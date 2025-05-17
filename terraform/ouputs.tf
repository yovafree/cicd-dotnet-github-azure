output "app_urls" {
  value = {
    for env, app in azurerm_linux_web_app.app :
    env => app.default_hostname
  }
}

output "acr_login_server" {
  value = azurerm_container_registry.acr.login_server
}
