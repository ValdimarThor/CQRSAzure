﻿Imports System.Configuration

''' <summary>
''' Wrapper class for the possible configuration elements and element collections that affect how the 
''' event sourcing library operates.
''' </summary>
Public Class CQRSAzureEventSourcingConfigurationSection
    Inherits ConfigurationSection

    <ConfigurationProperty(NameOf(ImplementationMaps), IsRequired:=False)>
    <ConfigurationCollection(GetType(CQRSAzureEventSourcingAggregateMapElement),
                             AddItemName:=CQRSAzureEventSourcingAggregateMapElementCollection.AddItemName)>
    Public ReadOnly Property ImplementationMaps As CQRSAzureEventSourcingAggregateMapElementCollection
        Get
            Return Me(NameOf(ImplementationMaps))
        End Get
    End Property

    <ConfigurationProperty(NameOf(Implementations), IsRequired:=False)>
    <ConfigurationCollection(GetType(CQRSAzureEventSourcingImplementationSettingsElement),
                             AddItemName:=CQRSAzureEventSourcingImplementationSettingsElementCollection.AddItemName)>
    Public ReadOnly Property Implementations As CQRSAzureEventSourcingImplementationSettingsElementCollection
        Get
            Return Me(NameOf(Implementations))
        End Get
    End Property

End Class
