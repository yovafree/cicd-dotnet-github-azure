variable "project_name" {
  type        = string
  description = "Nombre base del proyecto"
}

variable "subscription_id" {
  type        = string
  description = "ID de la suscripción de Azure"
}

variable "location" {
  type        = string
  default     = "centralus"
  description = "Ubicación de los recursos"
}

variable "acr_name" {
  type        = string
  description = "Nombre del Azure Container Registry (único globalmente)"
}

variable "image_name" {
  type        = string
  description = "Nombre de la imagen Docker"
}

variable "environments" {
  type = map(string)
  default = {
    dev  = "development"
    prod = "production"
  }
  description = "Lista de entornos"
}
