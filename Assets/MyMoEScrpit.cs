using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoEngage;
// using MoEngageClient;

public class MyMoEScrpit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MoEngageClient.SetAppStatus(MoEAppStatus.UPDATE);
        Debug.Log("MoE Unity My Script");

        MoEngageClient.SetUniqueId("UNITY_PLAYER_UZER");
        // MoEngageClient.SetAlias("UNITY_ASSASSINS_CREED");
        // MoEngageClient.Logout();

        MoEngageClient.SetFirstName("Desmond");
        MoEngageClient.SetLastName("Miles");
        MoEngageClient.SetEmail("Desmond@Hashashin.past");
        MoEngageClient.SetGender(MoEUserGender.MALE);

        MoEngageClient.SetUserAttribute("Song", "There's a room where the light won;t find you, holding hand when the walls comes tumbling down");


        Properties props = new Properties();
        props.AddBoolean("booleanAttr", true);
        props.AddString("stringAttr", "Some hidden knife attributes");
        props.SetNonInteractive();

        MoEngageClient.TrackEvent("UnityEvent", props);

        // MoEngageClient.RequestPushPermissionAndroid();
        // MoEngageClient.NavigateToSettingsAndroid();

        // MoEGameObject.PushNotifCallback += PushCallback;

        MoEngageClient.ShowInApp();

        Invoke("delayEvent", 30);
    }

    void delayEvent(){

        Properties props = new Properties();
        props.AddString("My Event", "My Attrib");

        MoEngageClient.TrackEvent("Delayed Event", props);
    }
    void Update()
    {
        
    }
}